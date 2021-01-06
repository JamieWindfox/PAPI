using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;
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
    public partial class GameCreationView : PAPIView, ITranslatableView
    {
        // Players only added for Test, remove in release!!!!!
        private static Dictionary<Player, Button> players_removeButtons = new Dictionary<Player, Button>();

        private static bool allComponentsAdded = false;

        private static GenreEnum selectedGenre = GenreEnum.NOT_VALID;

        public GameCreationView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            AddComponents();
            createGameButton.Enabled = false;
        }


        private void AddComponents()
        {
            if(allComponentsAdded)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Stopped creating table, because it already has been created before");
                return;
            }
            playerListPanel.AutoSize = true;
            playerListPanel.ColumnCount = 2;
            playerListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            playerListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            playerListPanel.Controls.Add(playerNameLabel, 0, 0);
            playerListPanel.RowCount = 1;

            playerListPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;


            m_buttons.Add(cancelButton);
            m_buttons.Add(createGameButton);
            m_buttons.Add(addPlayerButton);
            SetButtonDesign();
            allComponentsAdded = true;
            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
        }

        public void AddPlayer(Player player)
        {
            foreach(KeyValuePair<Player, Button> playerButton in players_removeButtons)
            {
                if(playerButton.Key._name == player._name)
                {
                    WfLogger.Log(this, LogLevel.WARNING, "Add player " + player._name + " not possible, there already is a player with this name");
                    return;
                }
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Add player " + player._name + " to list of players");

            playerListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            playerListPanel.RowCount++;

            // Show name of player and put it into list
            playerListPanel.Controls.Add(new Label()
            {
                Text = player._name,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Width = 200
            }, 0, players_removeButtons.Count+1);


            // Create formatted button and its functionality
            Button button = new Button()
            {
                Text = "",
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(40, 40),
                Name = "removePlayerButton" + (players_removeButtons.Count + 1)
            };

            string imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\cancel.bmp";
            Image image = Image.FromFile(imagePath);
            button.Image = (Image)(new Bitmap(image, new Size(40, 40)));

            playerListPanel.Controls.Add(button, 1, players_removeButtons.Count + 1);
            m_buttons.Add(button);
            button.Click += RemovePlayerButton_Click;

            players_removeButtons.Add(player, button);

            // Set all rows to same size
            foreach (RowStyle rowStyle in playerListPanel.RowStyles)
            {
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 44;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Added player " + player._name + " to List");
            SetButtonDesign();
        }

        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            string value = ((Button)sender).Name;
            Player playerToRemove = null;
            foreach(KeyValuePair<Player, Button> playerButton in players_removeButtons)
            {
                if(playerButton.Value == (Button)sender)
                {
                    playerToRemove = playerButton.Key;
                    break;
                }
            }
            if (playerToRemove != null)
            {
                int rowNumber = -1;
                foreach(Control control in playerListPanel.Controls)
                {
                    if(control.Text == playerToRemove._name)
                    {
                        rowNumber = playerListPanel.GetRow(control);
                        break;
                    }
                }
                
                WfLogger.Log(this, LogLevel.DEBUG, "Remove Player " + playerToRemove._name + " from List (Number " + rowNumber + ")");
                players_removeButtons.Remove(playerToRemove);

                TableLayoutHelper.RemoveRowNumber(playerListPanel, rowNumber);
            }
            else
            {
                WfLogger.Log(this, LogLevel.WARNING, "For the given Button no player was found, who could be removed");
            }
        }

        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == PAPIApplication.GetLanguage())
            {
                return;
            }
            
            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, gmNameLabel);
                Translate(resSet, gmIPLabel);
                gmNameLabel.Text += ": " + PAPIApplication._currentPlayer._name;
                gmIPLabel.Text += ": " + PAPIApplication._currentPlayer._ip;
                Translate(resSet, cancelButton);
                Translate(resSet, addPlayerButton);
                Translate(resSet, createGameButton);
                Translate(resSet, genreLabel);
                Translate(resSet, playerNameLabel);
                genreDropdown.Items[0] = TranslatedString(resSet, "genre_nuclear_fallout");
                genreDropdown.Items[1] = TranslatedString(resSet, "genre_medieval_fantasy");
                genreDropdown.Items[2] = TranslatedString(resSet, "genre_magical_world");
                genreDropdown.Items[3] = TranslatedString(resSet, "genre_space_opera");
            }
        }


        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Add new Player Button was clicked, open the Player Search Popup");
            ViewController.playerSearchPopup.Popup(this);

        }

        private void genreDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (genreDropdown.SelectedIndex)
            {
                case 0:
                    selectedGenre = GenreEnum.NUCLEAR_FALLOUT;
                    break;
                case 1:
                    selectedGenre = GenreEnum.MEDIEVAL_FANTASY;
                    break;
                case 2:
                    selectedGenre = GenreEnum.MAGICAL_WORLD;
                    break;
                case 3:
                    selectedGenre = GenreEnum.SPACE_OPERA;
                    break;
                default:
                    selectedGenre = GenreEnum.NOT_VALID;
                    break;
            }
            if(selectedGenre != GenreEnum.NOT_VALID)
            {
                createGameButton.Enabled = true;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Genre " + selectedGenre + " was selected in dropdown");
        }

        private void createGameButton_Click(object sender, EventArgs e)
        {
            if (selectedGenre != GenreEnum.NOT_VALID)
            {
                PAPIApplication.StartNewGame(selectedGenre);
                WfLogger.Log(this, LogLevel.DEBUG, "Create Game Button clicked, created a new Game (" + selectedGenre + ")");
                foreach(KeyValuePair<Player, Button> playerButton in players_removeButtons)
                {
                    PAPIApplication._runningGame.AddPlayer(playerButton.Key);
                }
                ViewController.gameView.Open(this);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Cancel Button was clicked, return to GMStartView");
            ViewController.startView.Open(this);
        }
    }
}
