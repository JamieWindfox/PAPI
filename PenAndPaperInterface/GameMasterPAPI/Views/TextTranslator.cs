using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    public static class TextTranslator
    {
        public static Language currentLanguage;
        public static void Translate(List<Control> controls, bool translateIfLanguageNotChanged)
        {
            if (currentLanguage == GameSettings.GetLanguage() && !translateIfLanguageNotChanged)
            {
                return;
            }
            string resFile;

            switch (GameSettings.GetLanguage())
            {
                case Language.GERMAN:
                    resFile = @".\Strings\\General_DE.resx";
                    currentLanguage = Language.GERMAN;
                    break;
                case Language.ENGLISH:
                default:
                    resFile = @".\Strings\\General_EN.resx";
                    currentLanguage = Language.ENGLISH;
                    break;
            }
            using (ResXResourceSet resSet = new ResXResourceSet(resFile))
            {
                foreach(Control control in controls)
                {
                    try
                    {
                        string newText = resSet.GetString(control.Name);
                        if (newText == "")
                        {
                            throw new KeyNotFoundException("There is no translation for '" + control.Name + "' in " + resFile);
                        }
                        control.Text = String.Empty;
                        control.Text = newText;
                    }
                    catch(Exception)
                    {
                        // control Text stays the same as it is
                    }
                    
                }
            }
        }
    }
}
