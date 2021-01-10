using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using PAPI.Logging;
using System.Threading.Tasks;

namespace PAPI.Serialization
{
    public class SerializationManager<Type>
    {
        private string _saveFile;
        public List<Type> _saveData;

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new SerializationManager with a given file name
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

            LockManager.GetLock(_saveFile, () =>
            {
                if (!File.Exists(_saveFile))
                {
                    File.Create(_saveFile);
                }
            }
            );
            
            _saveData = new List<Type>();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Code source for lockManager: https://www.codeproject.com/Tips/1190802/File-Locking-in-a-Multi-Threaded-Environment
        /// </summary>
        /// <param name="dataToSave"></param>
        public void Save(Type dataToSave)
        {
            _saveData.Add(dataToSave);
            string jsonString = JsonSerializer.Serialize(_saveData);

            LockManager.GetLock(_saveFile, () =>
                {
                    File.WriteAllText(_saveFile, jsonString);
                }
            );
            WfLogger.Log("SerializationManager.Save(data)", LogLevel.DEBUG, "Saved data: " + File.ReadAllText(_saveFile));
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Code source for lockManager: https://www.codeproject.com/Tips/1190802/File-Locking-in-a-Multi-Threaded-Environment
        /// </summary>
        /// <returns></returns>
        public List<Type> Load()
        {
            string jsonString = "";

            LockManager.GetLock(_saveFile, () =>
                {
                    jsonString = File.ReadAllText(_saveFile);
                }
            );

            try
            {
                _saveData = JsonSerializer.Deserialize<List<Type>>(jsonString);
            }
            catch(JsonException ex)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Json File is emptx and there is nothing to obtain.");
            }
            return (_saveData == null) ? new List<Type>() : _saveData;
        }

        // --------------------------------------------------------------------------------------------------------------------------------


        
        // --------------------------------------------------------------------------------------------------------------------------------



        // --------------------------------------------------------------------------------------------------------------------------------



        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
