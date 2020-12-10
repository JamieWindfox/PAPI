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

        public static string GetFilePath_Images(DesignEnum design)
        {
            return GetFilePath_Game() + "\\PAPIClasses\\Resources\\Images\\" + design.ToString().ToLower();
        }
    }
}
