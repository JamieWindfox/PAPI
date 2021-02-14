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
        private Dictionary<PAPIGame, Button> _gameButtons = new Dictionary<PAPIGame, Button>();
        private Dictionary<PAPIGame, Button> _deleteButtons = new Dictionary<PAPIGame, Button>();
        private List<PAPIGame> _savedGames = new List<PAPIGame>();
        private List<PAPIGame> _shownGames = new List<PAPIGame>();
        private string _deleteGameMessage = "Translation_DELETE_GAME_MESSAGE";

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
            gameTable.ColumnCount = 5;
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            //gameTable.Controls.Add(genre_label, 0, 0);
            //gameTable.Controls.Add(date_game_creation_label, 1, 0);
            gameTable.RowCount = 1;

            gameTable.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            ShowSavedGames();

            _buttons.Add(return_button);
            _buttons.Add(game_creator_button);
            SetButtonDesign();

            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
            SetTextToActiveLanguage();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Puts all saved games to the table
        /// </summary>
        public void ShowSavedGames()
        {
            // Show all saved Games
            int rowNr = 1;
            foreach (PAPIGame game in _savedGames)
            {
                if (_shownGames.Contains(game)) continue;

                WfLogger.Log(this, LogLevel.DEBUG, "Added game to list of saved games: " + game._genre + ", " + game._dateOfLastSession.ToString());
                gameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                gameTable.RowCount++;

                gameTable.Controls.RemoveByKey("dateofCreation_label_" + rowNr);
                // Date of creation label
                gameTable.Controls.Add(new Label()
                {
                    Name = "dateofCreation_label_" + rowNr,
                    Text = game._dateOfCreation.ToString(),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 1, rowNr);

                gameTable.Controls.RemoveByKey("dateofLastSave_label_" + rowNr);
                // Date of last save label
                gameTable.Controls.Add(new Label()
                {
                    Name = "dateofLastSave_label_" + rowNr,
                    Text = game._dateOfLastSession.ToString(),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                }, 2, rowNr);


                // Add load Game Button to current row
                gameTable.Controls.RemoveByKey("load_game_button_" + rowNr);
                Button loadButton = new Button()
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Size = new Size(40, 40),
                    Name = "load_game_button_" + rowNr
                };
                string imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\show.bmp";
                Image image = Image.FromFile(imagePath);
                loadButton.Image = (Image)(new Bitmap(image, new Size(40, 40)));
                gameTable.Controls.Add(loadButton, 3, rowNr);
                _gameButtons.Add(game, loadButton);
                _buttons.Add(loadButton);

                // Add Delete Game Button to current row
                gameTable.Controls.RemoveByKey(Name = "delete_game_button_" + rowNr);
                Button deleteButton = new Button()
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Size = new Size(40, 40),
                    Name = "delete_game_button_" + rowNr
                };
                imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\cancel.bmp";
                image = Image.FromFile(imagePath);
                deleteButton.Image = (Image)(new Bitmap(image, new Size(40, 40)));
                gameTable.Controls.Add(deleteButton, 4, rowNr);
                _deleteButtons.Add(game, deleteButton);
                _buttons.Add(deleteButton);
                _shownGames.Add(game);
                rowNr++;
            }


            // Add eventhandler for click on every show game button
            foreach (KeyValuePair<PAPIGame, Button> button in _gameButtons)
            {
                button.Value.Click += Load_Game_Button_Click;
            }

            // Add eventhandler for click on every show game button
            foreach (KeyValuePair<PAPIGame, Button> button in _deleteButtons)
            {
                button.Value.Click += Delete_Game_Button_Click;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------


        private void Load_Game_Button_Click(object sender, EventArgs e)
        {
            PAPIGame selectedGame = null;
            foreach(KeyValuePair<PAPIGame, Button> gameButton in _gameButtons)
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
            WfLogger.Log(this, LogLevel.DEBUG, "Button 'Load' was clicked, open new Session");
            PAPIApplication.StartSession(selectedGame);
            ((ShowGameOverviewView)ViewController.showGameOverviewView).Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void Delete_Game_Button_Click(object sender, EventArgs e)
        {
            PAPIGame selectedGame = null;
            foreach (KeyValuePair<PAPIGame, Button> deleteButton in _deleteButtons)
            {
                if (deleteButton.Value == (Button)sender)
                {
                    selectedGame = deleteButton.Key;
                    break;
                }
            }
            if (selectedGame == null)
            {
                throw new GameNotFoundException("There is no game for the clicked button");
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Button 'Delete' was clicked, open Messagebox");
            var resultYesNo = MessageBox.Show(_deleteGameMessage, "Delete Game", MessageBoxButtons.YesNo);
            if(resultYesNo == DialogResult.Yes)
            {
                DeleteGame(selectedGame);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------


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
                    gameTable.Controls.RemoveByKey("genre_label_game_" + row);
                    gameTable.Controls.Add(new Label()
                    {
                        Name = "genre_label_game_" + row,
                        Text = TranslatedString(resSet, "genre_" + _savedGames[row]._genre.ToString().ToLower()),
                        Anchor = AnchorStyles.Left | AnchorStyles.Top,
                        Width = 250
                    }, 0, row + 1);
                }
            }
            WfLogger.Log(this, LogLevel.DEBUG, "All text set to " + PAPIApplication.GetLanguage());
        }

        // --------------------------------------------------------------------------------------------------------------------------------


        private void returnButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return Button was clicked, return to " + ViewController.lastView.GetType());
            ViewController.startView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------


        private void newGameButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "The Create new Game Button was clicked, open CreateNewGameView");
            ViewController.gameCreationView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------


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
            // do nothing
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
