using System;
using System.IO;

namespace PAPI.Logging
{
    class FileLogger : LoggerBase
    {
        private String basePath = System.IO.Directory.GetCurrentDirectory();
        private string directoryPath;
        private string filePath;
        private bool writeLogToConsoleToo = true;

        public FileLogger(LogLevel logLevel)
        {
            directoryPath = GetFilePath();
            filePath = directoryPath + "Log_" + (GetHighestLogFileID() + 1) % 10 + ".txt";

            if (File.Exists(filePath))
            {
                filePath = GetNameOfOldestLogFile();
            }
            m_logLevel = logLevel;
            StreamWriter streamWriter = new System.IO.StreamWriter(filePath);
            m_lastLog = "LOGGER - " + DateTime.Now.ToString();
            streamWriter.WriteLine(m_lastLog);
            streamWriter.Close();
        }

        private string GetFilePath()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string papiPath = "PenAndPaperInterface";
            int startIndexOfRemoval = path.IndexOf(papiPath);
            return path.Remove(startIndexOfRemoval + papiPath.Length) + "\\Logs\\";
        }

        /**
         * Logs a message to the Logfile if its LogLevel is lower or equal than the Loggers LogLevel
         */
        public override void Log(string nameOfObj, LogLevel logLevel, string message)
        {
            lock (lockObject)
            {
                m_lastLog = (GetTimeAsString() + " " + nameOfObj + " " + logLevel + ": " + message);

                if (writeLogToConsoleToo)
                {
                    Console.WriteLine(m_lastLog);
                }
                File.AppendAllText(filePath, m_lastLog + Environment.NewLine);
            }
        }

        public override void Log(object obj, LogLevel logLevel, string message)
        {
            lock (lockObject)
            {
                m_lastLog = (GetTimeAsString() + " " + obj.GetType() + " " + logLevel + ": " + message);

                if (writeLogToConsoleToo)
                {
                    Console.WriteLine(m_lastLog);
                }
                File.AppendAllText(filePath, m_lastLog + Environment.NewLine);
            }
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
            String[] files = { };
            try
            {
                files = Directory.GetFiles(directoryPath);
            }
            catch (DirectoryNotFoundException e)
            {
                Directory.CreateDirectory(directoryPath);
            }
            int highestnumber = -1;

            foreach(String fileName in files)
            {
                String ending = ".txt";
                String file = "Log_";
                String trimmedFileName = fileName.Trim(directoryPath.ToCharArray());
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
            String[] files = Directory.GetFiles(directoryPath);
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
