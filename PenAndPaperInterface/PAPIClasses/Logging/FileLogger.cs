using System;
using System.IO;

namespace PAPI.Logging
{
    class FileLogger : LoggerBase
    {
        private const String BASE_PATH = @"C:\Users\Windfuchs\OneDrive\Dokumente\Game_Develoment\Byothrea\Logs\";
        private string m_filePath;
        private bool m_writeLogToConsoleToo = true;
        private FileSystemInfo m_fileInfo;

        public FileLogger(LogLevel logLevel)
        {
            m_filePath = BASE_PATH + "ByothreaLog_" + (GetHighestLogFileID() + 1) % 10 + ".txt";
            if(File.Exists(m_filePath))
            {
                m_filePath = GetNameOfOldestLogFile();
            }
            m_logLevel = logLevel;
            StreamWriter streamWriter = new System.IO.StreamWriter(m_filePath);
            m_lastLog = "BYOTHREA LOGGER - " + DateTime.Now.ToString();
            streamWriter.WriteLine(m_lastLog);
            streamWriter.Close();
        }

        /**
         * Logs a message to the Logfile if its LogLevel is lower or equal than the Loggers LogLevel
         */
        public override void Log(string type, LogLevel logLevel, string message)
        {
            lock (lockObject)
            {
                m_lastLog = (GetTimeAsString() + " " + type + " " + logLevel + ": " + message);

                if (m_writeLogToConsoleToo)
                {
                    Console.WriteLine(m_lastLog);
                }
                File.AppendAllText(m_filePath, m_lastLog + Environment.NewLine);
            }
        }

        public override void Log(LogLevel logLevel, string message)
        {
            Log("", logLevel, message);
        }

        public override void Log(string message)
        {
            Log(LogLevel.DEBUG, message);
        }

        private string GetTimeAsString()
        {
            DateTime now = DateTime.Now;
            String time = "";
            if (now.Hour < 10)
                time += "0";
            time += now.Hour.ToString() + ":";

            if (now.Minute < 10)
                time += "0";
            time += now.Minute.ToString() + ":";

            if (now.Second < 10)
                time += "0";
            time += now.Second.ToString() + ":";

            if (now.Millisecond < 10)
                time += "0";
            if(now.Millisecond < 100)
                time += "0";

            time += now.Millisecond.ToString();

            return time;
        }

        // Returns the number of the last written LogFile; If this is the first one, return -1
        private int GetHighestLogFileID()
        {
            String[] files = Directory.GetFiles(BASE_PATH);
            int highestnumber = -1;

            foreach(String fileName in files)
            {
                String ending = ".txt";
                String file = "ByothreaLog_";
                String trimmedFileName = fileName.Trim(BASE_PATH.ToCharArray());
                trimmedFileName = trimmedFileName.Trim(file.ToCharArray());
                trimmedFileName = trimmedFileName.Trim(ending.ToCharArray());
                int currentNumber = Int16.Parse(trimmedFileName);
                if (currentNumber > highestnumber)
                {
                    highestnumber = currentNumber;
                }
            }
            return highestnumber;
        }

        private String GetNameOfOldestLogFile()
        {
            String[] files = Directory.GetFiles(BASE_PATH);
            String oldest = null;

            foreach (String fileName in files)
            {
                if(oldest == null)
                {
                    oldest = fileName;
                }
                else
                {
                    if(File.GetCreationTime(fileName) < File.GetCreationTime(oldest))
                    {
                        oldest = fileName;
                    }
                }
            }
            return oldest;
        }

    }
}
