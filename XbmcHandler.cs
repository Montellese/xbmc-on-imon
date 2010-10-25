using System;

using iMon.DisplayApi;
using XBMC.JsonRpc;
using System.Threading;

namespace iMon.XBMC
{
    internal class XbmcHandler : IDisposable
    {
        #region Private variables

        private bool disposed;

        private XbmcJsonRpcConnection xbmc;
        private DisplayTextHandler text;

        #endregion

        #region Public variables

        #endregion

        #region Constructor

        public XbmcHandler(XbmcJsonRpcConnection xbmc, DisplayTextHandler text)
        {
            if (xbmc == null)
            {
                throw new ArgumentNullException("xbmc");
            }
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            this.xbmc = xbmc;
            this.text = text;

            this.xbmc.Player.PlaybackStarted        +=  this.xbmcPlaybackStarted;
            this.xbmc.Player.PlaybackPaused         +=  this.xbmcPlaybackPaused;
            this.xbmc.Player.PlaybackResumed        +=  this.xbmcPlaybackResumed;
            this.xbmc.Player.PlaybackStopped        +=  this.xbmcPlaybackStopped;
            this.xbmc.Player.PlaybackEnded          +=  this.xbmcPlaybackEnded;
            this.xbmc.Player.PlaybackSeek           +=  this.xbmcPlaybackSeek;
            this.xbmc.Player.PlaybackSeekChapter    +=  this.xbmcPlaybackSeek;
            this.xbmc.Player.PlaybackSpeedChanged   +=  this.xbmcPlaybackSpeedChanged;
        }

        #endregion

        #region Public functions

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

        private void xbmcPlaybackStarted(object sender, XbmcPlayerPlaybackChangedEventArgs e)
        {
            // TODO: XBMC PlaybackStarted
        }

        private void xbmcPlaybackPaused(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            this.text.Set("Pause", "Pause", e.Position.ToString());
        }

        private void xbmcPlaybackResumed(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            // TODO: XBMC PlaybackResumed
        }

        private void xbmcPlaybackStopped(object sender, EventArgs e)
        {
            // TODO: XBMC PlaybackStopped
        }

        private void xbmcPlaybackEnded(object sender, EventArgs e)
        {
            // TODO: XBMC PlaybackEnded
        }

        private void xbmcPlaybackSeek(object sender, XbmcPlayerPlaybackPositionChangedEventArgs e)
        {
            // TODO: XBMC PlaybackSeek
        }

        private void xbmcPlaybackSpeedChanged(object sender, XbmcPlayerPlaybackSpeedChangedEventArgs e)
        {
            // TODO: XBMC PlaybackSpeedChanged
        }

        #endregion

        #region Private functions

        #endregion
    }
}
