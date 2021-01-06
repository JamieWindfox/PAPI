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
using PAPI.Settings.Game;

namespace GameMasterPAPI.Views
{
    public partial class GMOptionsView : PAPIView
    {
        private string cachedPlayerName;
        public GMOptionsView() : base()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            m_buttons.Add(returnButton);
            SetButtonDesign();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == PAPIApplication.GetLanguage() && cachedPlayerName == PAPIApplication._currentPlayer._name)
            {
                return;
            }
            cachedPlayerName = PAPIApplication._currentPlayer._name;

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, languageLabel);
                Translate(resSet, designLabel);
                Translate(resSet, returnButton);
                Translate(resSet, gmNameLabel);
                gmNameInputField.Text = cachedPlayerName;
                designDropdown.Items[0] = TranslatedString(resSet, "designMedieval");
                designDropdown.Items[1] = TranslatedString(resSet, "designModern");
                languageDropdown.Items[0] = TranslatedString(resSet, "languageEnglish");
                languageDropdown.Items[1] = TranslatedString(resSet, "languageGerman");

            }
            WfLogger.Log(this, LogLevel.DEBUG, "All text set to " + PAPIApplication.GetLanguage());
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void languageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(languageDropdown.SelectedIndex)
            {
                case 0:
                    PAPIApplication.SetLanguage(LanguageEnum.ENGLISH);
                    break;
                case 1:
                    PAPIApplication.SetLanguage(LanguageEnum.GERMAN);
                    break;
                default:
                    PAPIApplication.SetLanguage(LanguageEnum.ENGLISH);
                    break;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Set language to " +  PAPIApplication.GetLanguage() + " in dropdown");
            SetTextToActiveLanguage();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void designDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignEnum chosenDesign = PAPIApplication.GetDesign();
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
            if (chosenDesign != PAPIApplication.GetDesign())
            {
                PAPIApplication.SetDesign(chosenDesign);
                WfLogger.Log(this, LogLevel.DEBUG, "Set design to " + PAPIApplication.GetDesign() + " in dropdown");
                SetDesign();
                SetButtonDesign();
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void gmNameInputField_TextChanged(object sender, EventArgs e)
        {
            PAPIApplication._currentPlayer.SetName(gmNameInputField.Text);
            WfLogger.Log(this, LogLevel.DEBUG, "Set game master name to " + PAPIApplication._currentPlayer._name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void returnButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return button was clicked, and view changes to " + ViewController.lastView.GetType());
            ViewController.lastView.Open(this);
        }
    }
}
