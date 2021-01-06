using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using PAPI.Exception;
using PAPI.Settings.Game;

namespace GameMasterPAPI.Views
{
    public partial class GameSelectionView : PAPIView, ITranslatableView
    {
        private Dictionary<PAPIGame, Button> _gameButtons = new Dictionary<PAPIGame, Button>();
        private List<PAPIGame> _savedGames = new List<PAPIGame>();

        public GameSelectionView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized SelectGameView");
            AddComponents();
        }

        private void AddComponents()
        {
            gameTable.AutoSize = true;
            gameTable.ColumnCount = 3;
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            gameTable.Controls.Add(genreLabel, 0, 0);
            gameTable.Controls.Add(dateLabel, 1, 0);
            gameTable.RowCount = 1;

            gameTable.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            ShowSavedGames();
            
            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
            SetTextToActiveLanguage();
        }

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

             
                // Add show Game Button to current row
                Button button = new Button()
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Size = new Size(40, 40),
                    Name = "showButton" + rowNr
                };
                string imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\show.bmp";
                Image image = Image.FromFile(imagePath);
                button.Image = (Image)(new Bitmap(image, new Size(40, 40)));
                gameTable.Controls.Add(button, 3, rowNr);
                _gameButtons.Add(game, button);
                gameTable.Controls.Add(button, 2, rowNr++);
                m_buttons.Add(button);
            }

            // Set size of each row to same
            foreach (RowStyle rowStyle in gameTable.RowStyles)
            {
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 44;
            }

            m_buttons.Add(returnButton);
            m_buttons.Add(newGameButton);
            SetButtonDesign();

            // Add eventhandler for click on every show game button
            foreach (KeyValuePair<PAPIGame, Button> button in _gameButtons)
            {
                button.Value.Click += GameButton_Click;
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
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
            WfLogger.Log(this, LogLevel.DEBUG, "Button 'Show' was clicked, open Popup");
            PAPIApplication.StartSession(selectedGame);
            ((ShowGameOverviewView)ViewController.showGameOverviewView).Open(this);
        }


        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == PAPIApplication.GetLanguage())
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, savedGamesLabel);
                Translate(resSet, returnButton);
                Translate(resSet, startButton);
                Translate(resSet, newGameButton);
                Translate(resSet, dateLabel);
                Translate(resSet, genreLabel);
                
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return Button was clicked, return to " + ViewController.lastView.GetType());
            ViewController.startView.Open(this);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "The Create new Game Button was clicked, open CreateNewGameView");
            ViewController.gameCreationView.Open(this);
        }

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

        private void GameSelectionView_Load(object sender, EventArgs e)
        {
            // do nothing
        }
    }
}
