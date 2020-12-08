using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PAPI.Settings
{
    public class GameSettings
    {
        // The currently set Genre
        private static GenreEnum activeGenre;

        // The currently set Design
        private static DesignEnum activeDesign;

        // The currently set language for all printed strings
        private static Language activeLanguage;

        // Is a sessions running at the moment?
        private static bool isSessionRunning = false;

        // Name of the current GM
        private static GameMaster m_gm = new GameMaster("GAME MASTER");

        


        // ################################################# GETTER #################################################
        public static List<GenreEnum> GetAllGenres()
        {
            return Enum.GetValues(typeof(GenreEnum)).Cast<GenreEnum>().ToList();
        }

        public static List<DesignEnum> GetAllDesigns()
        {
            return Enum.GetValues(typeof(DesignEnum)).Cast<DesignEnum>().ToList();
        }

        public static List<Language> GetAllLanguages()
        {
            return Enum.GetValues(typeof(Language)).Cast<Language>().ToList();
        }

        public static GenreEnum GetGenre() { return activeGenre; }

        // Converts the gieven GenreEnum to a string
        public static string ToString(GenreEnum genre)
        {
            switch(genre)
            {
                case GenreEnum.MAGICAL_WORLD: return "magicalWorld";
                case GenreEnum.MEDIEVAL_FANTASY: return "medievalFantasy";
                case GenreEnum.NUCLEAR_FALLOUT: return "nuclearFallout";
                case GenreEnum.SPACE_OPERA: return "spaceOpera";
                default: return "NOT_VALID";
            }
        }
        public static DesignEnum GetDesign() { return activeDesign; }
        public static Language GetLanguage() { return activeLanguage; }
        public static GameMaster GetGm() { return m_gm; }

        // ################################################# SETTER #################################################

        public static void SetActiveDesign(DesignEnum design)
        {
            activeDesign = design;
            WfLogger.Log("GameSettings.SetActiveDesign(DesignEnum)", LogLevel.DEBUG, "Set active design to " + design);
        }

        public static void SetActiveGenre(GenreEnum genre)
        {
            if(!isSessionRunning)
            {
                activeGenre = genre;
                WfLogger.Log("GameSettings.SetActiveGenre(GenreEnum)", LogLevel.DEBUG, "Set active genre to " + genre);
            }
            else
            {
                WfLogger.Log("GameSettings.SetActiveGenre(GenreEnum)", LogLevel.WARNING, "Couldn't set active genre to " + genre + ", becuase there is a session running");
            }
        }

        public static void SetActiveLanguage(Language language)
        {
            activeLanguage = language;
            WfLogger.Log("GameSettings.SetActiveLanguage(Language)", LogLevel.DEBUG, "Set active language to " + language);
        }

        public static void SetGmName(string name)
        {
            m_gm.SetName(name);
        }
    }
}