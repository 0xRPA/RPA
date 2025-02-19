using System;
using System.Diagnostics;

namespace RPA.Activity.Core
{
    public static class ActivityTrace
    {
        private static TraceSource sTC = new TraceSource("RPAActivityTraceSource", SourceLevels.All);

        public static void Verbose(string message)
        {
            sTC.TraceEvent(TraceEventType.Verbose, 0, message);
        }
        public static void Verbose(string format, params string[] args)
        {
            sTC.TraceEvent(TraceEventType.Verbose, 0, format, args);
        }

        public static void Info(string message)
        {
            sTC.TraceEvent(TraceEventType.Information, 0, message);
        }
        public static void Info(string format, params string[] args)
        {
            sTC.TraceEvent(TraceEventType.Information, 0, format, args);
        }

        public static void Warning(string message)
        {
            sTC.TraceEvent(TraceEventType.Warning, 0, message);
        }
        public static void Warning(string format, params string[] args)
        {
            sTC.TraceEvent(TraceEventType.Warning, 0, format, args);
        }

        public static void Error(string message)
        {
            sTC.TraceEvent(TraceEventType.Error, 0, message);
        }
        public static void Error(string format, params string[] args)
        {
            sTC.TraceEvent(TraceEventType.Error, 0, format, args);
        }

        public static void Exception(string message, Exception e)
        {
            string msg = message + " " + e.ToString();
            sTC.TraceEvent(TraceEventType.Error, 0, msg);
        }
    }
}
