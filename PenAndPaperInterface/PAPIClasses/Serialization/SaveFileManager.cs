using PAPI.Character.CharacterTypes;
using PAPI.Item;
using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace PAPI.Serialization
{
    public static class SaveFileManager
    {
        private static bool _isInitialized = false;
        public static SerializationManager<AppSettings> _settingManager { get; private set; }
        public static SerializationManager<PAPIGame> _gameManager { get; private set; }
        public static SerializationManager<PAPICharacter> _characterManager { get; private set; }
        public static SerializationManager<PAPIItem> _itemManager { get; private set; }
        //public static SerializationManager<PAPIVehicle> _vehicleManager { get; private set; }
        //public static SerializationManager<PAPIBuilding> _buildingManager { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        private static void Init()
        {
            if (_isInitialized) return;
            _settingManager = new SerializationManager<AppSettings>("\\saveFiles\\settings.json");
            _gameManager = new SerializationManager<PAPIGame>("\\saveFiles\\games.json");
            _characterManager = new SerializationManager<PAPICharacter>("characters");
            _itemManager = new SerializationManager<PAPIItem>("items");
            //_vehicleManager = new SerializationManager<PAPIVehicle>("vehicles");
            //_buildingManager = new SerializationManager<PAPIBuilding>("buildings");
            _isInitialized = true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Saves the given settings persistently in a save file
        /// </summary>
        /// <param name="settings"></param>
        public static void Save(AppSettings settings)
        {
            if (!_isInitialized) Init();
            _settingManager.Save(settings);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Saves the given game persistently in a save file
        /// </summary>
        /// <param name="game"></param>
        public static void Save(PAPIGame game)
        {
            if (!_isInitialized) Init();
            WfLogger.Log("SaveFileManager.Save()", LogLevel.DEBUG, "Pass game to SerializationManager to save");
            _gameManager.Save(game);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Saves the given character persistently in a save file
        /// </summary>
        /// <param name="character"></param>
        public static void Save(PAPICharacter character)
        {
            if (!_isInitialized) Init();
            WfLogger.Log("SaveFileManager.Save()", LogLevel.DEBUG, "Pass character to SerializationManager to save");
            _characterManager.Save(character);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Saves the given item persistently in a save file
        /// </summary>
        /// <param name="item"></param>
        public static void Save(PAPIItem item)
        {
            if (!_isInitialized) Init();
            WfLogger.Log("SaveFileManager.Save()", LogLevel.DEBUG, "Pass item to SerializationManager to save");
            _itemManager.Save(item);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Loads a saves file with the app settings
        /// </summary>
        /// <returns>returns persistantly saved settings</returns>
        public static AppSettings LoadSettings()
        {
            if (!_isInitialized) Init();

            List<AppSettings> settingsList = _settingManager.Load();

            if(settingsList == null || settingsList.Count == 0)
            {
                WfLogger.Log("SaveFileManager.LoadSettings()", LogLevel.DEBUG, "Couldn't read any data from the save file, return default Settings");
                return new AppSettings();
            }
            WfLogger.Log("SaveFileManager.LoadSettings()", LogLevel.DEBUG, "Could read data form save file and return the first AppSetting");
            return settingsList[0];           
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Loads a saves file with the saved games
        /// </summary>
        /// <returns>returns persistantly saved games</returns>
        public static List<PAPIGame> LoadGames()
        {
            if (!_isInitialized) Init();

            List<PAPIGame> gameList = _gameManager.Load();

            if (gameList == null || gameList.Count == 0)
            {
                WfLogger.Log("SaveFileManager.LoadGames()", LogLevel.DEBUG, "Couldn't read any data from the save file, return empty game list");
                return new List<PAPIGame>();
            }
            WfLogger.Log("SaveFileManager.LoadGames()", LogLevel.DEBUG, "Could read data from save file and return the saved games");
            return gameList;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Loads a saves file with the saved characters
        /// </summary>
        /// <returns>returns persistantly saved characters</returns>
        public static List<PAPICharacter> LoadCharacters()
        {
            if (!_isInitialized) Init();

            List<PAPICharacter> characterList = _characterManager.Load();

            if (characterList == null || characterList.Count == 0)
            {
                WfLogger.Log("SaveFileManager.LoadCharacters()", LogLevel.DEBUG, "Couldn't read any data from the save file, return empty character list");
                return new List<PAPICharacter>();
            }
            WfLogger.Log("SaveFileManager.LoadCharacters()", LogLevel.DEBUG, "Could read data from save file and return the saved characters");
            return characterList;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Loads a saves file with the saved items
        /// </summary>
        /// <returns>returns persistantly saved items</returns>
        public static List<PAPIItem> LoadItems()
        {
            if (!_isInitialized) Init();

            List<PAPIItem> itemList = _itemManager.Load();

            if (itemList == null || itemList.Count == 0)
            {
                WfLogger.Log("SaveFileManager.LoadItems()", LogLevel.DEBUG, "Couldn't read any data from the save file, return empty item list");
                return new List<PAPIItem>();
            }
            WfLogger.Log("SaveFileManager.LoadItems()", LogLevel.DEBUG, "Could read data from save file and return the saved items");
            return itemList;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
