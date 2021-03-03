using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace PAPIClient.Views
{
    public partial class GameCreationView : PAPIView, ITranslatableView
    {
        private static bool allComponentsAdded = false;

        private static GenreEnum _cachedGenre = GenreEnum.NOT_VALID;
        private Dictionary<GenreEnum, string> _genreDescriptions = new Dictionary<GenreEnum, string>();

        public GameCreationView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            AddComponents();
            create_and_start_button.Enabled = false;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void AddComponents()
        {
            if(allComponentsAdded)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Stopped creating table, because it already has been created before");
                return;
            }

            _buttons.Add(cancel_button);
            _buttons.Add(create_and_return_button);
            _buttons.Add(create_and_start_button);
            SetButtonDesign();
            allComponentsAdded = true;
            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
        }

        /* --------------------------------------------------------------------------------------------------------------------------------
         * Functionality removed, but code saved for other views 
        public void AddPlayer(Player player)
        {
            foreach(KeyValuePair<Player, Button> playerButton in players_removeButtons)
            {
                if(playerButton.Key._id == player._id)
                {
                    WfLogger.Log(this, LogLevel.WARNING, "Add player " + player._name + " not possible, there already is a player with this id");
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
            _buttons.Add(button);
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
        */
        // --------------------------------------------------------------------------------------------------------------------------------

        public override void SetTextToActiveLanguage()
        {
            if (_shownLanguage == PAPIApplication.GetLanguage())
            {
                return;
            }
            
            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, gm_name_label);
                Translate(resSet, game_id_label);
                gm_name.Text = PAPIApplication.GetPlayer()._name;
                id_textbox.Text = PAPIApplication.GetUniqueId();
                Translate(resSet, cancel_button);
                Translate(resSet, create_and_start_button);
                Translate(resSet, create_and_return_button);
                Translate(resSet, genre_label);
                genreDropdown.Items[0] = TranslatedString(resSet, "GenreEnum_NUCLEAR_FALLOUT");
                genreDropdown.Items[1] = TranslatedString(resSet, "GenreEnum_MEDIEVAL_FANTASY");
                genreDropdown.Items[2] = TranslatedString(resSet, "GenreEnum_MAGICAL_WORLD");
                genreDropdown.Items[3] = TranslatedString(resSet, "GenreEnum_SPACE_OPERA");

                _genreDescriptions.Clear();
                _genreDescriptions.Add(GenreEnum.NUCLEAR_FALLOUT, TranslatedDescription(resSet, "GenreEnum_NUCLEAR_FALLOUT"));
                _genreDescriptions.Add(GenreEnum.MEDIEVAL_FANTASY, TranslatedDescription(resSet, "GenreEnum_MEDIEVAL_FANTASY"));
                _genreDescriptions.Add(GenreEnum.MAGICAL_WORLD, TranslatedDescription(resSet, "GenreEnum_MAGICAL_WORLD"));
                _genreDescriptions.Add(GenreEnum.SPACE_OPERA, TranslatedDescription(resSet, "GenreEnum_SPACE_OPERA"));
                _genreDescriptions.Add(GenreEnum.NOT_VALID, TranslatedDescription(resSet, "GenreEnum_NOT_VALID"));
            }
        }


        // Functionality removed, but code is still there for reference
       /* private void addPlayerButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Add new Player Button was clicked, open the Player Search Popup");
            ViewController.playerSearchPopup.Popup(this);

        }*/

        private void genreDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (genreDropdown.SelectedIndex)
            {
                case 0:
                    _cachedGenre = GenreEnum.NUCLEAR_FALLOUT;
                    break;
                case 1:
                    _cachedGenre = GenreEnum.MEDIEVAL_FANTASY;
                    break;
                case 2:
                    _cachedGenre = GenreEnum.MAGICAL_WORLD;
                    break;
                case 3:
                    _cachedGenre = GenreEnum.SPACE_OPERA;
                    break;
                default:
                    _cachedGenre = GenreEnum.NOT_VALID;
                    break;
            }
            if(_cachedGenre != GenreEnum.NOT_VALID)
            {
                create_and_start_button.Enabled = true;
            }
            genre_description.Text = _genreDescriptions[_cachedGenre];

            WfLogger.Log(this, LogLevel.DEBUG, "Genre " + _cachedGenre + " was selected in dropdown");
        }

        private void create_and_start_button_Click(object sender, EventArgs e)
        {
            if (_cachedGenre != GenreEnum.NOT_VALID)
            {
                PAPIApplication.CreateNewGame(_cachedGenre, id_textbox.Text);
                WfLogger.Log(this, LogLevel.DEBUG, "Create and start Game Button clicked, created a new Game (" + _cachedGenre + ")");

                // Functionality removed, but keeping code for now as a reference
                /*foreach(KeyValuePair<Player, Button> playerButton in players_removeButtons)
                {
                    PAPIApplication._runningGame.AddPlayer(playerButton.Key);
                }*/
                // TODO: change to session overview
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Cancel Button was clicked, return to GameSelectionView");
            ViewController.gameSelectionView.Open(this);
        }

        private void create_and_return_button_Click(object sender, EventArgs e)
        {
            if (_cachedGenre != GenreEnum.NOT_VALID)
            {
                PAPIApplication.CreateNewGame(_cachedGenre, id_textbox.Text);
                WfLogger.Log(this, LogLevel.DEBUG, "Create Game and return Button clicked, created a new Game (" + _cachedGenre + ")");
                ViewController.gameSelectionView.SetTextToActiveLanguage();
                ((GameSelectionView)(ViewController.gameSelectionView)).ShowSavedGames();
                ViewController.gameSelectionView.Open(this);
            }
        }
    }
}
