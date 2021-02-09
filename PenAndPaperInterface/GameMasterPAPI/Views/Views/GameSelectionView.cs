using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using PAPI.Exception;
using PAPI.Settings.Game;
using PAPI.Serialization;

namespace PAPIClient.Views
{
    /// <summary>
    /// This view shows all created games and lets the player chose to create a new game; They also con delete games here
    /// </summary>
    public partial class GameSelectionView : PAPIView, ITranslatableView
    {
        private Dictionary<PAPIGame, Button> _loadGameButtons = new Dictionary<PAPIGame, Button>();
        private List<PAPIGame> _savedGames = new List<PAPIGame>();

        /// <summary>
        /// Loads saved games and adds all components/controls to the view
        /// </summary>
        public GameSelectionView()
        {
            _savedGames = SaveFileManager.LoadGames();
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized SelectGameView");
            AddComponents();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Adds all components/controls to the view
        /// </summary>
        private void AddComponents()
        {
            gameTable.AutoSize = true;
            gameTable.ColumnCount = 3;
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            gameTable.Controls.Add(genre_label, 0, 0);
            gameTable.Controls.Add(date_game_creation_label, 1, 0);
            gameTable.RowCount = 1;

            gameTable.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            ShowSavedGames();
            
            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
            SetTextToActiveLanguage();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Puts all saved games to the table
        /// </summary>
        private void ShowSavedGames()
        {
            // Show all saved Games
            int rowNr = 1;
            foreach (PAPIGame game in _savedGames)
            {
                WfLogger.Log(this, LogLevel.DEBUG, "Added game to list of saved games: " + game._genre + ", " + game._dateOfLastSession.ToString());
                gameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
                gameTable.RowCount++;

                // Date of creation label
                gameTable.Controls.Add(new Label()
                {
                    Text = game._dateOfCreation.ToString(),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Width = 200
                }, 1, rowNr);

                // Date of last save label
                gameTable.Controls.Add(new Label()
                {
                    Text = game._dateOfLastSession.ToString(),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Width = 200
                }, 1, rowNr);


                // Add show Game Button to current row
                Button loadGameBtn = new Button()
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Size = new Size(40, 40),
                    Name = "load_game_button_" + rowNr
                };
                string imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\show.bmp";
                Image image = Image.FromFile(imagePath);
                loadGameBtn.Image = (Image)(new Bitmap(image, new Size(40, 40)));
                gameTable.Controls.Add(loadGameBtn, 3, rowNr);
                _loadGameButtons.Add(game, loadGameBtn);
                //gameTable.Controls.Add(loadGameBtn, 2, rowNr++);
                _buttons.Add(loadGameBtn);

                // Add delete Game Button to current row
                Button deleteGameBtn = new Button()
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Size = new Size(40, 40),
                    Name = "delete_game_button_" + rowNr
                };
                imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\delete.bmp";
                image = Image.FromFile(imagePath);
                deleteGameBtn.Image = (Image)(new Bitmap(image, new Size(40, 40)));
                gameTable.Controls.Add(deleteGameBtn, 4, rowNr);
                _loadGameButtons.Add(game, deleteGameBtn);
                //gameTable.Controls.Add(deleteGameBtn, 2, rowNr++);
                _buttons.Add(deleteGameBtn);


            }

            // Set size of each row to same
            foreach (RowStyle rowStyle in gameTable.RowStyles)
            {
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 44;
            }

            _buttons.Add(return_button);
            _buttons.Add(game_creator_button);
            SetButtonDesign();

            // Add eventhandler for click on every show game button
            foreach (KeyValuePair<PAPIGame, Button> button in _loadGameButtons)
            {
                button.Value.Click += Load_Game_Button_Click;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------


        private void Load_Game_Button_Click(object sender, EventArgs e)
        {
            PAPIGame selectedGame = null;
            foreach(KeyValuePair<PAPIGame, Button> gameButton in _loadGameButtons)
            {
                if(gameButton.Value == (Button)sender)
                {
                    selectedGame = gameButton.Key;
                    break;
                }
            }
            if(selectedGame == null)
            {
                throw new GameNotFoundException("There is no game for the clicked button");
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Button 'Load' was clicked, open Popup");
            PAPIApplication.StartSession(selectedGame);
            ((ShowGameOverviewView)ViewController.showGameOverviewView).Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Translates all shown text to the set language
        /// </summary>
        public override void SetTextToActiveLanguage()
        {
            if (_shownLanguage == PAPIApplication.GetLanguage())
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, saved_games_label);
                Translate(resSet, return_button);
                Translate(resSet, load_game_button);
                Translate(resSet, game_creator_button);
                Translate(resSet, date_game_creation_label);
                Translate(resSet, genre_label);
                Translate(resSet, date_last_save_label);
                
                for (int row = 0; row < _savedGames.Count; ++row)
                {
                    gameTable.Controls.Add(new Label()
                    {
                        Text = TranslatedString(resSet, "genre_" + _savedGames[row]._genre.ToString().ToLower()),
                        Anchor = AnchorStyles.Left | AnchorStyles.Top,
                        Width = 250
                    }, 0, row + 1);
                }
            }
            WfLogger.Log(this, LogLevel.DEBUG, "All text set to " + PAPIApplication.GetLanguage());
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns to the Start View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return Button was clicked, return to " + ViewController.lastView.GetType());
            ViewController.startView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Starts the Game Creator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "The Create new Game Button was clicked, open CreateNewGameView");
            ViewController.gameCreationView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Deletes the selected game and removes it from the list
        /// </summary>
        /// <param name="game"></param>
        public void DeleteGame(PAPIGame game)
        {
            if (game != null)
            {
                int rowNumber = -1;
                foreach (Control control in gameTable.Controls)
                {
                    if (control.Text == game._dateOfCreation.ToString())
                    {
                        rowNumber = gameTable.GetRow(control);
                        break;
                    }
                }

                WfLogger.Log(this, LogLevel.DEBUG, "Remove Game " + game._genre + ", "  + game._dateOfCreation 
                    + " from List (Number " + rowNumber + ")");
                _savedGames.Remove(game);

                TableLayoutHelper.RemoveRowNumber(gameTable, rowNumber);
            }
            else
            {
                WfLogger.Log(this, LogLevel.WARNING, "No Game was found, which could be removed");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void GameSelectionView_Load(object sender, EventArgs e)
        {
            // do nothing when loading the view
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
