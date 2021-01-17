using PAPI.Settings;
using System;
using System.Resources;
using PAPI.Logging;
using PAPI.Settings.Game;
using PAPI.Serialization;

namespace PAPIClient.Views
{
    public partial class GMOptionsView : PAPIView
    {
        private string _cachedPlayerName;
        public GMOptionsView() : base()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            _buttons.Add(return_button);
            SetButtonDesign();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public override void SetTextToActiveLanguage()
        {
            if (_shownLanguage == PAPIApplication.GetLanguage() && _cachedPlayerName == PAPIApplication.GetPlayer()._name)
            {
                return;
            }
            _cachedPlayerName = PAPIApplication.GetPlayer()._name;

            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, language_label);
                Translate(resSet, design_label);
                Translate(resSet, return_button);
                Translate(resSet, player_name_label);
                Translate(resSet, player_id_label);
                playerName_inputField.Text = _cachedPlayerName;
                player_id_textbox.Text = PAPIApplication.GetPlayer()._id;
                design_dropdown.Items[0] = TranslatedEnum(resSet, DesignEnum.BLACK_ON_ANTIQUE);
                design_dropdown.Items[1] = TranslatedEnum(resSet, DesignEnum.GREEN_ON_BLACK);
                design_dropdown.Items[2] = TranslatedEnum(resSet, DesignEnum.BLACK_ON_WHITE);
                language_dropdown.Items[0] = TranslatedEnum(resSet, LanguageEnum.ENGLISH);
                language_dropdown.Items[1] = TranslatedEnum(resSet, LanguageEnum.GERMAN);
            }
            WfLogger.Log(this, LogLevel.DEBUG, "All text set to " + PAPIApplication.GetLanguage());
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void languageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageEnum chosenLanguage;
            switch (language_dropdown.SelectedIndex)
            {
                case 0:
                    chosenLanguage = LanguageEnum.ENGLISH;
                    break;
                case 1:
                    chosenLanguage = LanguageEnum.GERMAN;
                    break;
                default:
                    chosenLanguage = LanguageEnum.ENGLISH;
                    break;
            }
            if (chosenLanguage != PAPIApplication.GetLanguage())
            {
                PAPIApplication.SetLanguage(chosenLanguage);
                WfLogger.Log(this, LogLevel.DEBUG, "Set language to " + PAPIApplication.GetLanguage() + " in dropdown");
                SetTextToActiveLanguage();
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void designDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignEnum chosenDesign = PAPIApplication.GetDesign();
            switch (design_dropdown.SelectedIndex)
            {
                case 0:
                    chosenDesign = DesignEnum.BLACK_ON_ANTIQUE;
                    break;
                case 1:
                    chosenDesign = DesignEnum.GREEN_ON_BLACK;
                    break;
                case 2:
                    chosenDesign = DesignEnum.BLACK_ON_WHITE;
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

        private void playerNameInputField_TextChanged(object sender, EventArgs e)
        {
            PAPIApplication.GetPlayer().SetName(playerName_inputField.Text);
            WfLogger.Log(this, LogLevel.DEBUG, "Set player name to " + PAPIApplication.GetPlayer()._name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void returnButton_Click(object sender, EventArgs e)
        {
            SaveFileManager.Save(PAPIApplication.GetSettings());
            WfLogger.Log(this, LogLevel.DEBUG, "Return button was clicked, options are being saved and view changes to " + ViewController.lastView.GetType());
            ViewController.lastView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
