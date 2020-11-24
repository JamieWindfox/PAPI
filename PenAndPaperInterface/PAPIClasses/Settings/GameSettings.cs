using PAPIClasses;
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


        // ################################################# GETTER #################################################
        public static List<GenreEnum> GetAllGenres()
        {
            return Enum.GetValues(typeof(GenreEnum)).Cast<GenreEnum>().ToList();
        }

        // ################################################# SETTER #################################################

    }
}