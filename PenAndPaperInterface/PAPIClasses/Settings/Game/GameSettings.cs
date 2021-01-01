using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PAPI.Settings
{
    public static class GameSettings
    {
        /// <summary>
        /// The currently set Genre
        /// </summary>
        public static GenreEnum _activeGenre { get; private set; }

        /// <summary>
        /// The currently set Design
        /// </summary>
        public static DesignEnum _activeDesign { get; private set; }

        /// <summary>
        /// The currently set language for all printed strings
        /// </summary>
        public static LanguageEnum _activeLanguage { get; private set; }

        /// <summary>
        /// Is a sessions running at the moment?
        /// </summary>
        public static bool _isSessionRunning { get; private set; } = false;
        


        // --------------------------------------------------------------------------------------------------------------------------------
        public static List<GenreEnum> GetAllGenres()
        {
            return Enum.GetValues(typeof(GenreEnum)).Cast<GenreEnum>().ToList();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static List<DesignEnum> GetAllDesigns()
        {
            return Enum.GetValues(typeof(DesignEnum)).Cast<DesignEnum>().ToList();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static List<LanguageEnum> GetAllLanguages()
        {
            return Enum.GetValues(typeof(LanguageEnum)).Cast<LanguageEnum>().ToList();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void SetActiveDesign(DesignEnum design)
        {
            _activeDesign = design;
            WfLogger.Log("GameSettings.SetActiveDesign(DesignEnum)", LogLevel.DEBUG, "Set active design to " + design);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void SetActiveGenre(GenreEnum genre)
        {
            if(!_isSessionRunning)
            {
                _activeGenre = genre;
                WfLogger.Log("GameSettings.SetActiveGenre(GenreEnum)", LogLevel.DEBUG, "Set active genre to " + genre);
            }
            else
            {
                WfLogger.Log("GameSettings.SetActiveGenre(GenreEnum)", LogLevel.WARNING, "Couldn't set active genre to " + genre + ", becuase there is a session running");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void SetActiveLanguage(LanguageEnum language)
        {
            _activeLanguage = language;
            WfLogger.Log("GameSettings.SetActiveLanguage(Language)", LogLevel.DEBUG, "Set active language to " + language);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}