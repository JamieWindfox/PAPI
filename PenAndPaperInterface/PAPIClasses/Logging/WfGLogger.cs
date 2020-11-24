namespace PAPI.Logging
{
    public static class WfGLogger
    {
        private static LoggerBase logger = null;
        private static bool initialized = false;

        public static void InitLogger(LogLevel logLevel)
        {
            if (logger == null)
            {
                logger = new FileLogger(logLevel);
            }
            initialized = true;
        }

        public static void Log(string type, LogLevel logLevel, string message)
        {
            if (!initialized)
            {
                InitLogger(logLevel);
            }
            if (LogLevelLowerOrEqualTo(logLevel))
            {
                logger.Log(type, logLevel, message);
            }
        }

        private static bool LogLevelLowerOrEqualTo(LogLevel logLevel)
        {
            return logger.GetLogLevel() <= logLevel;
        }


    }
}
