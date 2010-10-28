using System;

using iMon.DisplayApi;
using XBMC.JsonRpc;
using System.Threading;
using System.Timers;
using System.Collections.Generic;
using iMon.XBMC.Properties;

namespace iMon.XBMC
{
    internal class XbmcHandler : IDisposable
    {
        #region Private variables

        private const int ProgressUpdateInterval = 5000;
        private const int DefaultTextDelay = 2000;

        private bool disposed;

        private XbmcJsonRpcConnection xbmc;
        private DisplayHandler display;

        private XbmcMediaPlayer player;
        private XbmcPlayable currentlyPlaying;

        private TimeSpan length;
        private TimeSpan position;
        private System.Timers.Timer progressTimer;

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

            this.displayIdle();
        }

        #endregion

        #region Public functions

        public void Update()
        {
            if (this.player == null)
            {
                this.displayIdle();
            }
        }

        #endregion

        #region Implementations of IDisposable

        public void Dispose()
        {
            if (!this.disposed)
            {
                this.xbmc.Player.PlaybackStarted -= this.xbmcPlaybackStarted;
                this.xbmc.Player.PlaybackPaused -= this.xbmcPlaybackPaused;
                this.xbmc.Player.PlaybackResumed -= this.xbmcPlaybackResumed;
                this.xbmc.Player.PlaybackStopped -= this.xbmcPlaybackStopped;
                this.xbmc.Player.PlaybackEnded -= this.xbmcPlaybackEnded;
                this.xbmc.Player.PlaybackSeek -= this.xbmcPlaybackSeek;
                this.xbmc.Player.PlaybackSeekChapter -= this.xbmcPlaybackSeek;
                this.xbmc.Player.PlaybackSpeedChanged -= this.xbmcPlaybackSpeedChanged;

                this.disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        #endregion

        #region Event handlers

        private void xbmcConnected(object sender, EventArgs e)
        {
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

            if (this.player != null)
            {
                this.player.GetTime(out this.position, out this.length);
                this.progressTimer.Start();

                this.updateCurrentlyPlaying();
            }
        }

        private void xbmcAborted(object sender, EventArgs e)
        {
            this.playbackStopped();
        }

        private void xbmcPlaybackStarted(object sender, XbmcPlayerPlaybackChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

            this.player = e.Player;

            this.player.GetTime(out this.position, out this.length);
            this.progressTimer.Start();

            this.updateCurrentlyPlaying();
        }

        private void xbmcPlaybackPaused(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

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

            this.position = e.Position;
            this.updateProgress();
            this.progressTimer.Start();

            this.updateCurrentlyPlaying();
        }

        private void xbmcPlaybackStopped(object sender, EventArgs e)
        {
            this.playbackStopped();
            this.display.SetText("STOP", "Playback", "stopped", DefaultTextDelay);
            this.displayIdle();
        }

        private void xbmcPlaybackEnded(object sender, EventArgs e)
        {
            this.playbackStopped();
            this.display.SetText("Playback ended", "Playback", "ended", DefaultTextDelay);
            this.displayIdle();
        }

        private void xbmcPlaybackSeek(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            if (e == null || e.Player == null)
            {
                return;
            }

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
                this.updateCurrentlyPlaying();

                this.progressTimer.Start();
            }
        }

        private void progressTimerUpdate(object sender, ElapsedEventArgs e) 
        {
            this.position += TimeSpan.FromMilliseconds(ProgressUpdateInterval);
            this.updateProgress();
        }

        #endregion

        #region Private functions

        private void displayIdle()
        {
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
            this.display.SetIcon(iMonLcdIcons.Shuffle, this.player.Random);
            this.display.SetIcon(iMonLcdIcons.Repeat, this.player.Repeat != XbmcRepeatTypes.Off);
            iMonLcdIcons icon;
            if (this.player is XbmcAudioPlayer)
            {
                icon = iMonLcdIcons.Music;
                this.currentlyPlaying = this.xbmc.Playlist.Audio.GetCurrentItem();
                this.display.SetText(((XbmcSong)this.currentlyPlaying).Artist + " - " + this.currentlyPlaying.Title);

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
                if (this.currentlyPlaying is XbmcTvEpisode)
                {
                    XbmcTvEpisode ep = (XbmcTvEpisode)this.currentlyPlaying;
                    this.display.SetText(ep.ShowTitle + ": S" + ep.Season.ToString("00") + "E" + ep.Episodes.ToString("00") + " " + ep.Title);
                }
                else
                {
                    this.display.SetText(this.currentlyPlaying.Title);
                }

                XbmcVideoPlayer video = (XbmcVideoPlayer)this.player;

            }

            this.display.SetIcon(icon, true);
        }

        #endregion
    }
}
