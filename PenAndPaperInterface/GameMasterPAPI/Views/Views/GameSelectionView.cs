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
    /// The Game Selection View shows all saved games and lets the player chose if they want to load or delete an existing game, 
    /// or if they want to create a new one
    /// </summary>
    public partial class GameSelectionView : PAPIView, ITranslatableView
    {
        private Dictionary<PAPIGame, Button> _loadGameButtons = new Dictionary<PAPIGame, Button>();
        private Dictionary<PAPIGame, Button> _deleteGameButtons = new Dictionary<PAPIGame, Button>();
        private List<PAPIGame> _savedGames = new List<PAPIGame>();

        // --------------------------------------------------------------------------------------------------------------------------------

        public GameSelectionView()
        {
            _savedGames = SaveFileManager.LoadGames();
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized SelectGameView");
            AddComponents();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void AddComponents()
        {
            gameTable.AutoSize = true;
            gameTable.ColumnCount = 3;
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            gameTable.Controls.Add(genre_label, 0, 0);
            gameTable.Controls.Add(date_label, 1, 0);
            gameTable.RowCount = 1;

            gameTable.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            ShowSavedGames();
            
            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
            SetTextToActiveLanguage();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void ShowSavedGames()
        {
            // Show all saved Games
            int rowNr = 1;
            foreach (PAPIGame game in _savedGames)
            {
                WfLogger.Log(this, LogLevel.DEBUG, "Added game to list of saved games: " + game._genre + ", " + game._dateOfLastSession.ToString());
                gameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
                gameTable.RowCount++;
                gameTable.Controls.Add(new Label()
                {
                    Text = game._dateOfLastSession.ToString(),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Width = 200
                }, 1, rowNr);

             
                // Add load Game Button to current row
                Button button = new Button()
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Size = new Size(40, 40),
                    Name = "load_game_button*" + rowNr
                };
                gameTable.Controls.Add(button, 3, rowNr);
                _loadGameButtons.Add(game, button);
                gameTable.Controls.Add(button, 2, rowNr++);
                _buttons.Add(button);
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
                button.Value.Click += load_game_button_Click;
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
                Translate(resSet, date_label);
                Translate(resSet, genre_label);
                
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
        private void load_game_button_Click(object sender, EventArgs e)
        {
            PAPIGame selectedGame = null;
            foreach (KeyValuePair<PAPIGame, Button> gameButton in _loadGameButtons)
            {
                if (gameButton.Value == (Button)sender)
                {
                    selectedGame = gameButton.Key;
                    break;
                }
            }
            if (selectedGame == null)
            {
                throw new GameNotFoundException("There is no game for the clicked button");
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Button 'Show' was clicked, open Popup");
            PAPIApplication.StartSession(selectedGame);
            ((ShowGameOverviewView)ViewController.showGameOverviewView).Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void return_button_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return Button was clicked, return to " + ViewController.startView.GetType());
            ViewController.startView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void new_game_button_Click(object sender, EventArgs e)
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

        private void delete_game_button_Click(object sender, EventArgs e)
        {

        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void GameSelectionView_Load(object sender, EventArgs e)
        {
            // do nothing
        }
    }
}
