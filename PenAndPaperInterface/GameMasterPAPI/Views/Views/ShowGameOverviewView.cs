using PAPI.Character.CharacterTypes;
using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace PAPIClient.Views
{
    public partial class ShowGameOverviewView : PAPIView, ITranslatableView
    {
        private GenreEnum shownGenre = GenreEnum.NOT_VALID;
        public ShowGameOverviewView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized ShowGamePopup");
            AddComponents();
        }

        private void AddComponents()
        {
            _buttons.Add(cancelButton);
            _buttons.Add(startButton);

            playerCharacterPanel.AutoSize = true;
            playerCharacterPanel.ColumnCount = 3;
            playerCharacterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            playerCharacterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            playerCharacterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            playerCharacterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            playerCharacterPanel.Controls.Add(playerNameLabel, 0, 0);
            playerCharacterPanel.Controls.Add(characterNameLabel, 1, 0);
            playerCharacterPanel.Controls.Add(speciesLabel, 2, 0);
            playerCharacterPanel.Controls.Add(careerLabel, 3, 0);
            playerCharacterPanel.RowCount = 1;

            playerCharacterPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            ShowPlayers();

            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
            SetTextToActiveLanguage();
        }

        private void ShowPlayers()
        {
            // Show all saved Games
            if(PAPIApplication._runningGame == null)
            {
                return;
            }
            int rowNr = 1;
            foreach (KeyValuePair<Player, PlayerCharacter> player in PAPIApplication._runningGame._playerParty)
            {
                WfLogger.Log(this, LogLevel.DEBUG, "Added player to list of players: " + player.Key._name + ", Character: " + player.Value._name);
                playerCharacterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
                playerCharacterPanel.RowCount++;
                playerCharacterPanel.Controls.Add(new Label()
                {
                    Text = player.Key._name,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 0, rowNr);
                playerCharacterPanel.Controls.Add(new Label()
                {
                    Text = player.Value._name,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 1, rowNr);
                playerCharacterPanel.Controls.Add(new Label()
                {
                    Text = player.Value._species._enum.ToString(), // TODO - Translation
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 2, rowNr);
                playerCharacterPanel.Controls.Add(new Label()
                {
                    Text = player.Value._career._nameKey,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 3, rowNr);

            }

            // Set size of each row to same
            foreach (RowStyle rowStyle in playerCharacterPanel.RowStyles)
            {
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 44;
            }

            SetButtonDesign();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public override void SetTextToActiveLanguage()
        {
            if ((_shownLanguage == PAPIApplication.GetLanguage() && PAPIApplication._runningGame != null &&
                shownGenre == PAPIApplication._runningGame._genre))
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, genreLabel);
                if (PAPIApplication._runningGame != null)
                {
                    genreLabel.Text += ": " + TranslatedString(resSet, EnumConverter.Convert(PAPIApplication._runningGame._genre));
                    Translate(resSet, creationDateLabel);
                    creationDateLabel.Text += ": " + PAPIApplication._runningGame._dateOfCreation.ToString();
                    Translate(resSet, lastSaveLabel);
                    lastSaveLabel.Text += ": " + PAPIApplication._runningGame._dateOfLastSession.ToString();
                }
                
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Cancel' Button was clicked, Popup closes");
            ViewController.lastView.Open(this);
            Hide();
        }


    }
}
