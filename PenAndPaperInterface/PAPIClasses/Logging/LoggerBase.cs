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
        public abstract void Log(string nameOfObj, LogLevel logLevel, string message);

        public abstract void Log(object obj, LogLevel logLevel, string message);

        protected string m_lastLog;


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
