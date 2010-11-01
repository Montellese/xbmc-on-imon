using System;
using System.Threading;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using iMon.DisplayApi;
using XBMC.JsonRpc;
using iMon.XBMC.Properties;

namespace iMon.XBMC
{
    internal partial class XbmcHandler : BackgroundWorker
    {
        #region Private variables

        private const int ProgressUpdateInterval = 5000;
        private const int DefaultTextDelay = 2000;
        private const int ControlModeUpdateInterval = 500;
        private const int ControlModeUnchangedDelay = 10000;

        private Semaphore semReady;
        private Semaphore semWork;

        private bool connected;

        private XbmcJsonRpcConnection xbmc;
        private DisplayHandler display;

        private XbmcMediaPlayer player;
        private XbmcPlayable currentlyPlaying;

        private TimeSpan length;
        private TimeSpan position;
        private System.Timers.Timer progressTimer;

        private ControlState controlModeState;
        private System.Timers.Timer controlModeTimer;
        private int controlModeUnchanged;

        #endregion

        #region Public variables

        #endregion

        #region Constructor

        public XbmcHandler(XbmcJsonRpcConnection xbmc, DisplayHandler display)
        {
            if (xbmc == null)
            {
                throw new ArgumentNullException("xbmc");
            }
            if (display == null)
            {
                throw new ArgumentNullException("display");
            }

            this.xbmc = xbmc;
            this.display = display;

            this.xbmc.Connected                     +=  this.xbmcConnected;
            this.xbmc.Aborted                       +=  this.xbmcAborted;
            this.xbmc.Player.PlaybackStarted        +=  this.xbmcPlaybackStarted;
            this.xbmc.Player.PlaybackPaused         +=  this.xbmcPlaybackPaused;
            this.xbmc.Player.PlaybackResumed        +=  this.xbmcPlaybackResumed;
            this.xbmc.Player.PlaybackStopped        +=  this.xbmcPlaybackStopped;
            this.xbmc.Player.PlaybackEnded          +=  this.xbmcPlaybackEnded;
            this.xbmc.Player.PlaybackSeek           +=  this.xbmcPlaybackSeek;
            this.xbmc.Player.PlaybackSeekChapter    +=  this.xbmcPlaybackSeek;
            this.xbmc.Player.PlaybackSpeedChanged   +=  this.xbmcPlaybackSpeedChanged;

            this.progressTimer = new System.Timers.Timer();
            this.progressTimer.Interval = ProgressUpdateInterval;
            this.progressTimer.Elapsed += progressTimerUpdate;
            this.progressTimer.AutoReset = true;

            this.WorkerReportsProgress = false;
            this.WorkerSupportsCancellation = true;

            this.controlModeState = new ControlState();
            this.controlModeTimer = new System.Timers.Timer();
            this.controlModeTimer.Interval = ControlModeUpdateInterval;
            this.controlModeTimer.Elapsed += controlModeTimerUpdate;
            this.controlModeTimer.AutoReset = true;

            this.semReady = new Semaphore(0, 1);
            this.semWork = new Semaphore(0, 1);
        }

        #endregion

        #region Public functions

        public void Update()
        {
            Logging.Log("XBMC Handler", "Update");
            if (!this.connected)
            {
                // No need to do anything as long as we are not connected with XBMC
                return;
            }

            if (this.player != null)
            {
                this.updateCurrentlyPlaying();
            }
            else if (!Settings.Default.XbmcControlModeEnable)
            {
                this.displayIdle();
            }

            this.updateIcons();

            // Updating the control mode timer
            this.controlModeState.Window = null;
            this.controlModeState.Control = null;
            if (Settings.Default.XbmcControlModeEnable && !this.controlModeTimer.Enabled)
            {
                this.controlModeTimer.Start();
            }
            else if (!Settings.Default.XbmcControlModeEnable && this.controlModeTimer.Enabled)
            {
                this.controlModeTimer.Stop();
            }
        }

        #endregion

        #region Overrides of BackgroundWorker

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            while (!this.CancellationPending)
            {
                // Wait until a connection has been established
                this.semReady.WaitOne();

                Logging.Log("XBMC Handler", "Start working");

                if (Settings.Default.XbmcControlModeEnable)
                {
                    this.controlModeTimer.Start();
                }

                while (!this.CancellationPending && this.connected)
                {
                    this.semWork.WaitOne();

                    this.Update();
                }

                Logging.Log("XBMC Handler", "Stop working");
            }

            Logging.Log("XBMC Handler", "Cancelled");

            this.xbmc.Player.PlaybackStarted -= this.xbmcPlaybackStarted;
            this.xbmc.Player.PlaybackPaused -= this.xbmcPlaybackPaused;
            this.xbmc.Player.PlaybackResumed -= this.xbmcPlaybackResumed;
            this.xbmc.Player.PlaybackStopped -= this.xbmcPlaybackStopped;
            this.xbmc.Player.PlaybackEnded -= this.xbmcPlaybackEnded;
            this.xbmc.Player.PlaybackSeek -= this.xbmcPlaybackSeek;
            this.xbmc.Player.PlaybackSeekChapter -= this.xbmcPlaybackSeek;
            this.xbmc.Player.PlaybackSpeedChanged -= this.xbmcPlaybackSpeedChanged;
        }

        #endregion

        #region Event handlers

        private void xbmcConnected(object sender, EventArgs e)
        {
            this.connected = true;

            bool audio, video, pictures;
            this.xbmc.Player.GetActivePlayers(out video, out audio, out pictures);

            if (video)
            {
                this.player = this.xbmc.Player.Video;
            }
            else if (audio)
            {
                this.player = this.xbmc.Player.Audio;
            }
            else if (pictures)
            {
                this.player = this.xbmc.Player.Pictures;
            }

            this.semReady.Release();

            if (this.player != null)
            {
                this.getTime(out this.position, out this.length);
                this.progressTimer.Start();
            }

            this.update();
        }

        private void xbmcAborted(object sender, EventArgs e)
        {
            this.connected = false;

            this.playbackStopped();
        }

        private void xbmcPlaybackStarted(object sender, XbmcPlayerPlaybackChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

            Logging.Log("XBMC Handler", "Playback started");

            this.player = e.Player;

            this.getTime(out this.position, out this.length);
            this.progressTimer.Start();

            this.update();
        }

        private void xbmcPlaybackPaused(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

            Logging.Log("XBMC Handler", "Playback paused");

            this.progressTimer.Stop();
            this.position = e.Position;
            this.updateProgress();

            this.display.SetText("Pause", "Pause", e.Position.ToString());
        }

        private void xbmcPlaybackResumed(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

            Logging.Log("XBMC Handler", "Playback resumed");

            this.position = e.Position;
            this.updateProgress();
            this.progressTimer.Start();

            this.update();
        }

        private void xbmcPlaybackStopped(object sender, EventArgs e)
        {
            Logging.Log("XBMC Handler", "Playback stopped");

            this.playbackStopped();
            this.display.SetText("STOP", "Playback", "stopped", DefaultTextDelay);

            this.update();
        }

        private void xbmcPlaybackEnded(object sender, EventArgs e)
        {
            Logging.Log("XBMC Handler", "Playback ended");

            this.playbackStopped();
            this.display.SetText("Playback ended", "Playback", "ended", DefaultTextDelay);

            this.update();
        }

        private void xbmcPlaybackSeek(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

            Logging.Log("XBMC Handler", "Playback seek");

            this.length = e.Length;
            this.position = e.Position;
            this.updateProgress();
        }

        private void xbmcPlaybackSpeedChanged(object sender, XbmcPlayerPlaybackSpeedChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

            Logging.Log("XBMC Handler", "Playback speed changed");

            this.position = e.Position;
            this.length = e.Length;
            this.updateProgress();

            if (e.Speed < 0)
            {
                this.display.SetText("Rewinding (" + (-e.Speed) + "x)", "Rewinding", (-e.Speed).ToString());

                this.progressTimer.Stop();
            }
            else if (e.Speed > 1)
            {
                this.display.SetText("Forwarding (" + e.Speed + "x)", "Rewinding", e.Speed.ToString());

                this.progressTimer.Stop();
            }
            else
            {
                this.update();

                this.progressTimer.Start();
            }
        }

        private void progressTimerUpdate(object sender, ElapsedEventArgs e) 
        {
            this.position += TimeSpan.FromMilliseconds(ProgressUpdateInterval);
            this.updateProgress();
        }

        private void controlModeTimerUpdate(object sender, ElapsedEventArgs e)
        {
            if (!Settings.Default.XbmcControlModeEnable || !this.connected)
            {
                this.controlModeTimer.Stop();
                this.updateCurrentlyPlaying();

                return;
            }

            if (this.controlModeUnchanged >= 0)
            {
                this.controlModeUnchanged += Convert.ToInt32(this.controlModeTimer.Interval);
            }

            if (this.player != null && Settings.Default.XbmcControlModeDisableDuringPlayback)
            {
                this.checkControlModeUnchanged();
                return;
            }

            IDictionary<string, string> info = xbmc.System.GetInfoLabels("System.CurrentWindow", "System.CurrentControl");
            if (info.Count != 2 || string.IsNullOrEmpty(info["System.CurrentControl"]))
            {
                this.checkControlModeUnchanged();
                return;
            }

            string display = string.Empty;
            if (Settings.Default.XbmcControlModeDisplayWindowName && !string.IsNullOrEmpty(info["System.CurrentWindow"]))
            {
                display = info["System.CurrentWindow"] + ": ";
            }

            string control = info["System.CurrentControl"];
            if (Settings.Default.XbmcControlModeRemoveBrackets && control.StartsWith("[") && control.EndsWith("]"))
            {
                control = control.Remove(0, 1);
                control = control.Remove(control.Length - 1, 1);
            }

            if (this.controlModeState.Window == info["System.CurrentWindow"] && this.controlModeState.Control == control)
            {
                this.checkControlModeUnchanged();
                return;
            }

            this.display.SetText(display + control);

            this.controlModeState.Window = info["System.CurrentWindow"];
            this.controlModeState.Control = control;
            this.controlModeUnchanged = 0;
        }

        #endregion

        #region Private functions

        private void update()
        {
            try
            {
                this.semWork.Release();
            }
            catch (SemaphoreFullException)
            { }
        }

        private void updateIcons()
        {
            Logging.Log("XBMC Handler", "Updating icons");

            // Updating Speaker icons
            this.display.SetIcons(new List<iMonLcdIcons>()
            {
                iMonLcdIcons.SpeakerFrontLeft, 
                iMonLcdIcons.SpeakerCenter,
                iMonLcdIcons.SpeakerFrontRight,
                iMonLcdIcons.SpeakerSideLeft,
                iMonLcdIcons.SpeakerLFE,
                iMonLcdIcons.SpeakerSideRight,
                iMonLcdIcons.SpeakerRearLeft,
                iMonLcdIcons.SpeakerSPDIF,
                iMonLcdIcons.SpeakerRearRight
            }, false);

            List<iMonLcdIcons> icons = new List<iMonLcdIcons>();
            if (Settings.Default.ImonSoundSystemEnable)
            {
                if (Settings.Default.ImonSoundSystemSPDIF)
                {
                    icons.Add(iMonLcdIcons.SpeakerSPDIF);
                }

                XbmcSoundSystems sound = (XbmcSoundSystems)Settings.Default.ImonSoundSystem;
                if (sound == XbmcSoundSystems.Mono_1_0)
                {
                    icons.Add(iMonLcdIcons.SpeakerCenter);
                }
                else
                {
                    icons.Add(iMonLcdIcons.SpeakerFrontLeft);
                    icons.Add(iMonLcdIcons.SpeakerFrontRight);

                    switch (sound)
                    {
                        case XbmcSoundSystems.Stereo_2_1:
                            icons.Add(iMonLcdIcons.SpeakerLFE);
                            break;

                        case XbmcSoundSystems.Quad_4_0:
                            icons.Add(iMonLcdIcons.SpeakerRearLeft);
                            icons.Add(iMonLcdIcons.SpeakerRearRight);
                            break;

                        case XbmcSoundSystems.Surround_5_0:
                            icons.Add(iMonLcdIcons.SpeakerRearLeft);
                            icons.Add(iMonLcdIcons.SpeakerRearRight);
                            icons.Add(iMonLcdIcons.SpeakerCenter);
                            break;

                        case XbmcSoundSystems.Surround_5_1:
                            icons.Add(iMonLcdIcons.SpeakerRearLeft);
                            icons.Add(iMonLcdIcons.SpeakerRearRight);
                            icons.Add(iMonLcdIcons.SpeakerCenter);
                            icons.Add(iMonLcdIcons.SpeakerLFE);
                            break;

                        case XbmcSoundSystems.Side_5_1:
                            icons.Add(iMonLcdIcons.SpeakerSideLeft);
                            icons.Add(iMonLcdIcons.SpeakerSideRight);
                            icons.Add(iMonLcdIcons.SpeakerCenter);
                            icons.Add(iMonLcdIcons.SpeakerLFE);
                            break;

                        case XbmcSoundSystems.Surround_7_1:
                            icons.Add(iMonLcdIcons.SpeakerSideLeft);
                            icons.Add(iMonLcdIcons.SpeakerSideRight);
                            icons.Add(iMonLcdIcons.SpeakerRearLeft);
                            icons.Add(iMonLcdIcons.SpeakerRearRight);
                            icons.Add(iMonLcdIcons.SpeakerCenter);
                            icons.Add(iMonLcdIcons.SpeakerLFE);
                            break;
                    }
                }
            }

            this.display.SetIcons(icons, true);

            // TODO: Updating VOL/REP/SFL/... icons
        }

        private void displayIdle()
        {
            Logging.Log("XBMC Handler", "Displaying Idle");

            if (Settings.Default.XbmcIdleStaticTextEnable)
            {
                this.display.SetText(Settings.Default.XbmcIdleStaticText);
            }
            else
            {
                // Sending an empty string does not have any effect
                this.display.SetText(" ");
            }
        }

        private void updateProgress()
        {
            this.display.SetProgress(this.position, this.length);
        }

        private void playbackStopped()
        {
            this.display.SetIcons(new List<iMonLcdIcons>() { 
                iMonLcdIcons.Music, iMonLcdIcons.Movie, iMonLcdIcons.Tv, 
                iMonLcdIcons.Photo, iMonLcdIcons.Webcast, iMonLcdIcons.NewsWeather
            }, false);

            this.player = null;
            this.currentlyPlaying = null;

            this.progressTimer.Stop();
            this.position = new TimeSpan();
            this.length = new TimeSpan();

            this.updateProgress();

            this.display.HideAllIcons();
        }

        private void updateCurrentlyPlaying()
        {
            if (this.player == null)
            {
                return;
            }

            Logging.Log("XBMC Handler", "Updating currently playing file");

            this.display.SetIcon(iMonLcdIcons.Shuffle, this.player.Random);
            this.display.SetIcon(iMonLcdIcons.Repeat, this.player.Repeat != XbmcRepeatTypes.Off);
            iMonLcdIcons icon;
            if (this.player is XbmcAudioPlayer)
            {
                icon = iMonLcdIcons.Music;
                this.currentlyPlaying = this.xbmc.Playlist.Audio.GetCurrentItem();
                if (this.currentlyPlaying != null)
                {
                    this.display.SetText(((XbmcSong)this.currentlyPlaying).Artist + " - " + this.currentlyPlaying.Title, ((XbmcSong)this.currentlyPlaying).Artist, this.currentlyPlaying.Title);
                }
                else
                {
                    // Using InfoLabels as backup
                    IDictionary<string, string> info = this.xbmc.System.GetInfoLabels("MusicPlayer.Title", "MusicPlayer.Artist");
                    if (info.Count > 0)
                    {
                        string lcd = string.Empty;
                        string vfdUpper = string.Empty;
                        string vfdLower = string.Empty;

                        if (info.ContainsKey("MusicPlayer.Artist"))
                        {
                            lcd = info["MusicPlayer.Artist"];
                            vfdUpper = info["MusicPlayer.Artist"];
                        }
                        if (info.ContainsKey("MusicPlayer.Title"))
                        {
                            if (!string.IsNullOrEmpty(lcd))
                            {
                                lcd += " - ";
                            }
                            lcd += info["MusicPlayer.Title"];
                            vfdLower = info["MusicPlayer.Title"];
                        }

                        this.display.SetText(lcd, vfdUpper, vfdLower);
                    }
                    else
                    {
                        string path = this.xbmc.System.GetInfoLabel("Player.Filenameandpath");

                        if (!string.IsNullOrEmpty(path))
                        {
                            this.display.SetText(Path.GetFileNameWithoutExtension(path));
                        }
                    }
                }

                XbmcAudioPlayer audio = (XbmcAudioPlayer)this.player;

            }
            else if (this.player is XbmcPicturePlayer)
            {
                icon = iMonLcdIcons.Photo;
                this.display.SetText("SLIDESHOW", "Picture", "Slideshow");
            }
            else
            {
                icon = iMonLcdIcons.Movie;
                this.currentlyPlaying = this.xbmc.Playlist.Video.GetCurrentItem();
                if (this.currentlyPlaying != null)
                {
                    if (this.currentlyPlaying is XbmcTvEpisode)
                    {
                        XbmcTvEpisode ep = (XbmcTvEpisode)this.currentlyPlaying;
                        this.display.SetText(ep.ShowTitle + ": S" + ep.Season.ToString("00") + "E" + ep.Episodes.ToString("00") + " " + ep.Title);
                    }
                    else
                    {
                        this.display.SetText(this.currentlyPlaying.Title);
                    }
                }
                else
                {
                    // Using InfoLabels as backup
                    IDictionary<string, string> info = this.xbmc.System.GetInfoLabels("VideoPlayer.Title", "VideoPlayer.TVShowTitle");
                    if (info.Count > 0)
                    {
                        string lcd = string.Empty;
                        string vfdUpper = string.Empty;
                        string vfdLower = string.Empty;

                        if (info.ContainsKey("VideoPlayer.TVShowTitle"))
                        {
                            lcd = info["VideoPlayer.TVShowTitle"];
                            vfdUpper = info["VideoPlayer.TVShowTitle"];
                        }
                        if (info.ContainsKey("VideoPlayer.Title"))
                        {
                            if (!string.IsNullOrEmpty(lcd))
                            {
                                lcd += ": ";
                            }
                            string title = Path.GetFileNameWithoutExtension(info["VideoPlayer.Title"]);

                            lcd += title;
                            vfdLower = title;
                        }

                        this.display.SetText(lcd, vfdUpper, vfdLower);
                    }
                    else
                    {
                        string path = this.xbmc.System.GetInfoLabel("Player.Filenameandpath");

                        if (!string.IsNullOrEmpty(path))
                        {
                            this.display.SetText(Path.GetFileNameWithoutExtension(path));
                        }
                    }
                }

                XbmcVideoPlayer video = (XbmcVideoPlayer)this.player;

            }

            this.display.SetIcon(icon, true);
        }

        private void getTime(out TimeSpan position, out TimeSpan length)
        {
            position = new TimeSpan();
            length = new TimeSpan();

            if (this.player is XbmcVideoPlayer)
            {
                ((XbmcVideoPlayer)this.player).GetTime(out this.position, out this.length);
            } 
            else if (this.player is XbmcAudioPlayer)
            {
                ((XbmcAudioPlayer)this.player).GetTime(out this.position, out this.length);
            }
        }

        private void checkControlModeUnchanged()
        {
            if (this.controlModeUnchanged >= ControlModeUnchangedDelay)
            {
                this.controlModeUnchanged = -1;
                this.updateCurrentlyPlaying();
            }
        }

        #endregion
    }
}
