namespace PAPI.Logging
{
    public enum LogLevel
    {
        DETAILED,
        DEBUG,
        INFO,
        WARNING,
        ERROR,
        FATAL
    }

    public abstract class LoggerBase
    {
        protected LogLevel m_logLevel;

        protected readonly object lockObject = new object();
        public abstract void Log(object obj, LogLevel logLevel, string message);

        protected string m_lastLog;

        public abstract void Log(LogLevel logLevel, string message);

        // Default without Level given: DEBUG
        public abstract void Log(string message);

        public LogLevel GetLogLevel()
        {
            return m_logLevel;
        }

        public string GetLastLog()
        {
            return m_lastLog;
        }
    }
}
