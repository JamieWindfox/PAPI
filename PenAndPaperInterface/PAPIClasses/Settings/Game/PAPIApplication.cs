using PAPI.Exception;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using PAPI.Logging;
using PAPI.Serialization;

namespace PAPI.Settings.Game
{
    /// <summary>
    /// Class for the currently running instance of the Application
    /// </summary>
    public static class PAPIApplication
    {
        /// <summary>
        /// the settings of the application, regarding design and language
        /// </summary>
        private static AppSettings _settings { get; set; } = new AppSettings();

        /// <summary>
        /// The currently runing game, null if no game is running
        /// </summary>
        public static PAPIGame _runningGame { get; private set; } = null;

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void Start()
        {
            _settings = new AppSettings();
            _settings = SaveFileManager.LoadSettings();
            _runningGame = null;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <returns>The IP of the device on which the app runs</returns>
        public static string GetLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new NetworkException("No network adapters with an IPv4 address in the system!");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <returns>A list of all genres</returns>
        public static List<GenreEnum> GetAllGenres()
        {
            return Enum.GetValues(typeof(GenreEnum)).Cast<GenreEnum>().ToList();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Calls the CTOR of PAPIGame and creates a new game with the given genre and the current player as game master
        /// </summary>
        /// <param name="genre"></param>
        public static void CreateNewGame(GenreEnum genre)
        {
            _runningGame = new PAPIGame(genre, null, null, DateTime.Now, DateTime.Now, null);

            WfLogger.Log("PAPIApplication.CreateNewGame", LogLevel.DEBUG, "Created new Game");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the running game to the given value
        /// </summary>
        /// <param name="selectedGame">if null, nothing happens</param>
        public static void StartSession(PAPIGame selectedGame)
        {
            if(selectedGame == null)
            {
                WfLogger.Log("Application.StartSession()", LogLevel.WARNING, "Couldn't start session, because the game is null");
                return;
            }
            _runningGame = selectedGame;

            WfLogger.Log("PAPIApplication.StartSession", LogLevel.DEBUG, "Started new Session of Game");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void SetLanguage(LanguageEnum language)
        {
            _settings.SetActiveLanguage(language);
            WfLogger.Log("PAPIApplication.SetLanguage", LogLevel.DEBUG, "Set Language to " + language);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void SetDesign(DesignEnum design)
        {
            _settings.SetActiveDesign(design);
            WfLogger.Log("PAPIApplication.SetDesign", LogLevel.DEBUG, "Set Design to " + design);
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        public static DesignEnum GetDesign()
        {
            if(_settings == null)
            {
                _settings = new AppSettings();
            }
            return _settings._activeDesign;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        public static LanguageEnum GetLanguage()
        {
            if (_settings == null)
            {
                _settings = new AppSettings();
            }
            return _settings._activeLanguage;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static Player GetPlayer()
        {
            if (_settings == null)
            {
                _settings = new AppSettings();
            }
            return _settings._player;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static AppSettings GetSettings()
        {
            if (_settings == null)
            {
                _settings = new AppSettings();
            }
            return _settings;
        }
    }
}
