using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using PAPI.Logging;

namespace GameMasterPAPI.Views
{
    public partial class GMOptionsView : PAPIView
    {
        private string cachedGmName;
        public GMOptionsView() : base()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            m_buttons.Add(returnButton);
            SetButtonDesign();
        }


        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == GameSettings.GetLanguage() && cachedGmName == CurrentPlayer.player.name)
            {
                return;
            }
            cachedGmName = CurrentPlayer.player.name;

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, languageLabel);
                Translate(resSet, designLabel);
                Translate(resSet, returnButton);
                Translate(resSet, gmNameLabel);
                gmNameInputField.Text = cachedGmName;
                designDropdown.Items[0] = TranslatedString(resSet, "designMedieval");
                designDropdown.Items[1] = TranslatedString(resSet, "designModern");
                languageDropdown.Items[0] = TranslatedString(resSet, "languageEnglish");
                languageDropdown.Items[1] = TranslatedString(resSet, "languageGerman");

            }
            WfLogger.Log(this, LogLevel.DEBUG, "All text set to " + GameSettings.GetLanguage());
        }

        private void languageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(languageDropdown.SelectedIndex)
            {
                case 0:
                    GameSettings.SetActiveLanguage(Language.ENGLISH);
                    break;
                case 1:
                    GameSettings.SetActiveLanguage(Language.GERMAN);
                    break;
                default:
                    GameSettings.SetActiveLanguage(Language.ENGLISH);
                    break;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Set language to " + GameSettings.GetLanguage() + " in dropdown");
            SetTextToActiveLanguage();
        }

        private void designDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignEnum chosenDesign = GameSettings.GetDesign();
            switch (designDropdown.SelectedIndex)
            {
                case 0:
                    chosenDesign = DesignEnum.MEDIEVAL;
                    break;
                case 1:
                    chosenDesign = DesignEnum.MODERN;
                    break;
                default:
                    break;
            }
            if (chosenDesign != GameSettings.GetDesign())
            {
                GameSettings.SetActiveDesign(chosenDesign);
                WfLogger.Log(this, LogLevel.DEBUG, "Set design to " + GameSettings.GetDesign() + " in dropdown");
                SetDesign();
                SetButtonDesign();
            }
        }

        private void gmNameInputField_TextChanged(object sender, EventArgs e)
        {
            CurrentPlayer.player.SetName(gmNameInputField.Text);
            WfLogger.Log(this, LogLevel.DEBUG, "Set game master name to " + CurrentPlayer.player.name);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return button was clicked, and view changes to " + ViewController.lastView.GetType());
            ViewController.lastView.Open(this);
        }
    }
}
