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

    public static void Save(AppSettings newSettings)
        {
            if (!_isInitialized) Init();
            _settingManager.Save(newSettings);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Loads a saves file with the type of the given parameter
        /// </summary>
        /// <param name="settings">Needed for determining the type, thats going to be returned</param>
        /// <returns>returns persistantly saved settings</returns>
        public static AppSettings Load(AppSettings settings)
        {
            if (!_isInitialized) Init();
            List<AppSettings> settingList = _settingManager.Load();
            if(settingList == null || settingList.Count == 0)
            {
                // nothing happens, the settings stay the same
            }
            else
            {
                settings = settingList[0];
            }
            return settings;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
