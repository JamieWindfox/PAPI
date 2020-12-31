using PAPI.Character;
using PAPI.Character.CharacterTypes;
using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
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
            m_buttons.Add(cancelButton);
            m_buttons.Add(deleteButton);
            m_buttons.Add(startButton);

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
            if(RunningGame.game == null)
            {
                return;
            }
            int rowNr = 1;
            foreach (KeyValuePair<Player, PlayerCharacter> player in RunningGame.game._playerParty)
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
                    Text = player.Value._species._nameKey,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 2, rowNr);
                playerCharacterPanel.Controls.Add(new Label()
                {
                    Text = player.Value._career._name,
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

        public override void SetTextToActiveLanguage()
        {
            if ((activeLanguage == GameSettings._activeLanguage && RunningGame.game != null && shownGenre == RunningGame.game._genre))
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, genreLabel);
                if (RunningGame.game != null)
                {
                    genreLabel.Text += ": " + TranslatedString(resSet, "genre_" + RunningGame.game._genre.ToString().ToLower());
                    Translate(resSet, creationDateLabel);
                    creationDateLabel.Text += ": " + RunningGame.game._dateOfCreation.ToString();
                    Translate(resSet, lastSaveLabel);
                    lastSaveLabel.Text += ": " + RunningGame.game._dateOfLastSession.ToString();
                }
                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Cancel' Button was clicked, Popup closes");
            ViewController.lastView.Open(this);
            Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Delete' Button was clicked, 'Are you sure?' Prompt opens");
            DeleteGamePromptPopup areYouSurePromt = new DeleteGamePromptPopup();
            areYouSurePromt.Popup(this);
        }
    }
}
