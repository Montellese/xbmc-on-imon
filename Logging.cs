using System;
using System.Text;
using System.IO;

using iMon.XBMC.Properties;

namespace iMon.XBMC
{
    internal static class Logging
    {
        #region Private variables

        internal const string ErrorLog = "error.log";
        internal const string DebugLog = "debug.log";
        internal const string OldLog = ".old";

        #endregion

        #region Public functions

        public static void Error(string message)
        {
            Error("GUI", message, null);
        }

        public static void Error(string area, string message)
        {
            Error(area, message, null);
        }

        public static void Error(string message, Exception exception)
        {
            Error("GUI", message, exception);
        }

        public static void Error(string area, string message, Exception exception)
        {
            if (Settings.Default.GeneralDebugEnable)
            {
                Log(area, "ERROR " + message, exception);
                return;
            }

            try 
            {
                using (StreamWriter file = new StreamWriter(ErrorLog, true, Encoding.UTF8))
                {
                    file.WriteLine("{0} [{1}] {2}", DateTime.Now, area, message);
                    if (exception != null)
                    {
                        file.WriteLine("    {0}: {1}" + Environment.NewLine +
                                       "         {2}", exception.GetType().Name, exception.Message, exception.StackTrace);
                    }
                }
            }
            catch (Exception)
            { }
        }

        public static void Log(string message)
        {
            Log("GUI", message, null);
        }

        public static void Log(string area, string message)
        {
            Log(area, message, null);
        }

        public static void Log(string message, Exception exception)
        {
            Log("GUI", message, exception);
        }

        public static void Log(string area, string message, Exception exception)
        {
            if (!Settings.Default.GeneralDebugEnable)
            {
                return;
            }

            try
            {
                using (StreamWriter file = new StreamWriter(DebugLog, true, Encoding.UTF8))
                {
                    file.WriteLine("{0} [{1}] {2}", DateTime.Now, area, message);
                    if (exception != null)
                    {
                        file.WriteLine("    {0}: {1}" + Environment.NewLine +
                                       "         {2}", exception.GetType().Name, exception.Message, exception.StackTrace);
                    }
                }
            }
            catch (Exception)
            { }
        }

        #endregion
    }
}
