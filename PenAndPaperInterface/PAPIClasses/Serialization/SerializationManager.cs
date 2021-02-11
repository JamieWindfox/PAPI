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
                    _ = CreateFile(_saveFile);
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
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// </summary>
        /// <param name="dataToSave"></param>
        public void Save(Type dataToSave)
        {
            _saveData.Add(dataToSave);
            string jsonString = JsonSerializer.Serialize(_saveData);
            bool exceptionThrown = false;

            lock(_saveFile)
            {
                try
                {
                    File.WriteAllText(_saveFile, jsonString);
                }
                catch(IOException exc)
                {
                    exceptionThrown = true;
                    WfLogger.Log("SerializationManager.Save(data)", LogLevel.ERROR, "An exception was trown: " + exc.Message);
                }
            }

            if(exceptionThrown)
            {
                WfLogger.Log("SerializationManager.Save(data)", LogLevel.DEBUG, "Couldn't save data");
            }
            else WfLogger.Log("SerializationManager.Save(data)", LogLevel.DEBUG, "Saved data: " + File.ReadAllText(_saveFile));
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
        /// Loads the save file and reads from it
        /// If the file is new, there is an io exception thrown, but then the file is empty anyways, so the program can continue normally
        /// </summary>
        /// <returns>A list of th eread objects of the given type</returns>
        public List<Type> Load()
        {
            string jsonString = "";

            if(!File.Exists(_saveFile))
            {
                _ = CreateFile(_saveFile);
            }
            lock(_saveFile)
            {
                try
                {
                    jsonString = File.ReadAllText(_saveFile);
                }
                catch(IOException exc)
                {
                    WfLogger.Log(this, LogLevel.ERROR, "An Exception was thrown while reading from file (" + _saveFile + "): " + exc.Message 
                        + ", but as this error is only thrown when the file is new and empty, this doesn't matter that much");

                    return new List<Type>();
                }
            }

            try
            {
                _saveData = JsonSerializer.Deserialize<List<Type>>(jsonString);
            }
            catch(JsonException)
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
