using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using PAPI.Logging;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace PAPI.Serialization
{
    public class SerializationManager<Type>
    {
        private string _saveFile;
        public List<Type> _saveData;
        private static Object lockObj = new Object();

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new SerializationManager with a given file name
        /// Source: https://codereview.stackexchange.com/questions/49158/writing-to-file-in-a-thread-safe-manner
        /// </summary>
        /// <param name="saveFileName">Please only give a name withouth path or file endings</param>
        public SerializationManager(string saveFileName)
        {
            if (saveFileName.Contains("\\"))
            {
                int start = saveFileName.LastIndexOf("\\");
                saveFileName = saveFileName.Remove(0, start + 1);
            }
            if(saveFileName.Contains("."))
            {
                int end = saveFileName.LastIndexOf(".");
                saveFileName = saveFileName.Remove(end);
            }

            _saveFile = GameDirectory.GetFilePath_SaveFiles() + saveFileName + ".json";


            lock(_saveFile)
            {
                if (!File.Exists(_saveFile))
                {
                    CreateFile(_saveFile);
                }
            }

            
            _saveData = new List<Type>();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Source: https://codereview.stackexchange.com/questions/49158/writing-to-file-in-a-thread-safe-manner
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private async Task CreateFile(string fileName)
        {
            int timeOut = 100;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                try
                {
                    lock (lockObj)
                    {
                        File.Create(fileName);
                        WfLogger.Log(this, LogLevel.INFO, "Created file: " + fileName);
                    }
                    break;
                }
                catch
                {
                    WfLogger.Log(this, LogLevel.ERROR, "Creation of file not possible");
                }
                if (stopwatch.ElapsedMilliseconds > timeOut)
                {
                    WfLogger.Log(this, LogLevel.WARNING, "Timeout while trying create file");
                    break;
                }

                await Task.Delay(5);
            }
            stopwatch.Stop();
            Thread.Sleep(100);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// </summary>
        /// <param name="dataToSave"></param>
        public void Save(Type dataToSave)
        {
            _saveData.Add(dataToSave);
            string jsonString = JsonSerializer.Serialize(_saveData);

            lock(_saveFile)
            {
                File.WriteAllText(_saveFile, jsonString);
            }

            WfLogger.Log("SerializationManager.Save(data)", LogLevel.DEBUG, "Saved data: " + File.ReadAllText(_saveFile));
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Source: https://codereview.stackexchange.com/questions/49158/writing-to-file-in-a-thread-safe-manner
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public async Task WriteToFileAsync(string jsonString)
        {
            int timeOut = 100;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while(true)
            {
                try
                {
                    lock(lockObj)
                    {
                        using (FileStream file = new FileStream(_saveFile, FileMode.Append, FileAccess.Write, FileShare.Read))
                        using (StreamWriter writer = new StreamWriter(file, Encoding.Unicode))
                        {
                            writer.Write(jsonString);
                            WfLogger.Log(this, LogLevel.INFO, "Wrote data to file");
                        }
                    }
                    break;
                }
                catch
                {
                    WfLogger.Log(this, LogLevel.ERROR, "File is not available");
                }
                if(stopwatch.ElapsedMilliseconds > timeOut)
                {
                    WfLogger.Log(this, LogLevel.WARNING, "Timeout while trying to save data");
                    break;
                }

                await Task.Delay(5);
            }
            stopwatch.Stop();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public List<Type> Load()
        {
            string jsonString = "";

            lock(_saveFile)
            {
                jsonString = File.ReadAllText(_saveFile);
            }


            try
            {
                _saveData = JsonSerializer.Deserialize<List<Type>>(jsonString);
            }
            catch(JsonException ex)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Json File is empty and there is nothing to obtain.");
            }
            return (_saveData == null) ? new List<Type>() : _saveData;
        }

        // --------------------------------------------------------------------------------------------------------------------------------


        
        // --------------------------------------------------------------------------------------------------------------------------------



        // --------------------------------------------------------------------------------------------------------------------------------



        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
