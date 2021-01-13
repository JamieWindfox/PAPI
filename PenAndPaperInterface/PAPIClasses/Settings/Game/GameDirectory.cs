using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Settings
{
    public static class GameDirectory
    {
        public static string GetFilePath_Game()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string papiPath = "PenAndPaperInterface";
            int startIndexOfRemoval = path.IndexOf(papiPath);
            return path.Remove(startIndexOfRemoval + papiPath.Length);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static string GetFilePath_SaveFiles()
        {
            return GetFilePath_Game() + "\\SaveFiles\\";
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <param name="design"></param>
        /// <returns>The path of the file which includes all images for the given design</returns>
        public static string GetFilePath_Images(DesignEnum design)
        {
            return GetFilePath_Game() + "\\PAPIClasses\\Resources\\Images\\" + design.ToString().ToLower();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <param name="language"></param>
        /// <returns>The File of translations for the given language</returns>
        public static string GetTranslationFile(LanguageEnum language)
        {
            string path = GetFilePath_Game() + "\\PAPIClasses\\Resources\\Strings_";
            switch (language)
            {
                case LanguageEnum.ENGLISH: return path + "EN.resx";
                case LanguageEnum.GERMAN: return path + "DE.resx";
                default: return path + "EN.resx";
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
