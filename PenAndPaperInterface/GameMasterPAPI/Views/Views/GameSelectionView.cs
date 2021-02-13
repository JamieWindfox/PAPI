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
    /// The table can show up to 10 saved games - the maximum number of games that can be saved per account
    /// </summary>
    public partial class GameSelectionView : PAPIView, ITranslatableView
    {
        private List<PAPIGame> _savedGames = new List<PAPIGame>();
        private List<PAPIGame> _shownGames = new List<PAPIGame>();
        private string _deleteGameYesNoText = "Translation_DELETE_GAME_QUESTION";

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

            _buttons.Add(game_creator_button);
            _buttons.Add(return_button);
            _buttons.Add(load_game_button_1);
            _buttons.Add(load_game_button_2);
            _buttons.Add(load_game_button_3);
            _buttons.Add(load_game_button_4);
            _buttons.Add(load_game_button_5);
            _buttons.Add(load_game_button_6);
            _buttons.Add(load_game_button_7);
            _buttons.Add(load_game_button_8);
            _buttons.Add(load_game_button_9);
            _buttons.Add(load_game_button_10);
            _buttons.Add(delete_game_button_1);
            _buttons.Add(delete_game_button_2);
            _buttons.Add(delete_game_button_3);
            _buttons.Add(delete_game_button_4);
            _buttons.Add(delete_game_button_5);
            _buttons.Add(delete_game_button_6);
            _buttons.Add(delete_game_button_7);
            _buttons.Add(delete_game_button_8);
            _buttons.Add(delete_game_button_9);
            _buttons.Add(delete_game_button_10);

            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
            SetTextToActiveLanguage();
        }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Adds a Button to show the given game to the given row of the table
        /// </summary>
        /// <param name="rowNr"></param>
        /// <param name="game"></param>
        private void AddLoadGameButton(int rowNr, PAPIGame game)
        {
            // Add show Game Button to current row
            Button showGameBtn = new Button()
            {
                Text = "",
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Right,
                Dock = DockStyle.None,
                Size = new Size(40, 40),
                Name = "load_game_button_" + rowNr
            };
            string imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\show.bmp";
            Image image;
            try
            {
                image = Image.FromFile(imagePath);
                showGameBtn.Image = (Image)(new Bitmap(image, new Size(40, 40)));
            }
            catch (Exception e)
            {
                WfLogger.Log(this, LogLevel.ERROR, $"An error occured while loading the image: {e.Message}");
                showGameBtn.Text = "*";
            }
            gameTable.Controls.Add(showGameBtn, 3, rowNr);
            _buttons.Add(showGameBtn);

        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Adds a Button to delete the given game to the given row of the table
        /// </summary>
        /// <param name="rowNr"></param>
        /// <param name="game"></param>
        private void AddDeleteGameButton(int rowNr, PAPIGame game)
        {
            // Add show Game Button to current row
            Button deleteButton = new Button()
            {
                Text = "",
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.None,
                Anchor = AnchorStyles.Right,
                Size = new Size(40, 40),
                Name = "delete_game_button_" + rowNr
            };
            string imagePath = GameDirectory.GetFilePath_Images(PAPIApplication.GetDesign()) + "\\delete.bmp";
            Image image;
            try
            {
                image = Image.FromFile(imagePath);
                deleteButton.Image = (Image)(new Bitmap(image, new Size(40, 40)));
            }
            catch (Exception e)
            {
                WfLogger.Log(this, LogLevel.ERROR, $"An error occured while loading the image: {e.Message}");
                deleteButton.Text = "X";
            }
            gameTable.Controls.Add(deleteButton, 3, rowNr);
            _buttons.Add(deleteButton);

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
                Translate(resSet, load_game_button_1);
                Translate(resSet, game_creator_button);
                Translate(resSet, date_game_creation_label);
                Translate(resSet, genre_label_1);
                Translate(resSet, date_last_save_label);
                TranslatedString(resSet, _deleteGameYesNoText);


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

        // Load Game Button Event Handlers
        private void load_game_button_1_Click(object sender, EventArgs e) { LoadGame(1); }
        private void load_game_button_2_Click(object sender, EventArgs e) { LoadGame(2); }
        private void load_game_button_3_Click(object sender, EventArgs e) { LoadGame(3); }
        private void load_game_button_4_Click(object sender, EventArgs e) { LoadGame(4); }
        private void load_game_button_5_Click(object sender, EventArgs e) { LoadGame(5); }
        private void load_game_button_6_Click(object sender, EventArgs e) { LoadGame(6); }
        private void load_game_button_7_Click(object sender, EventArgs e) { LoadGame(7); }
        private void load_game_button_8_Click(object sender, EventArgs e) { LoadGame(8); }
        private void load_game_button_9_Click(object sender, EventArgs e) { LoadGame(9); }
        private void load_game_button_10_Click(object sender, EventArgs e) { LoadGame(10); }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void LoadGame(int number)
        {
            if(_savedGames.Count >= number && _savedGames[number] != null) // game exists
            {
                WfLogger.Log(this, LogLevel.DEBUG, $"Load game number {number}");
                // TODO: load game and open StartSessionView
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        // Delete Game Button Event Handlers
        private void delete_game_button_1_Click(object sender, EventArgs e) { DeleteGame(1); }
        private void delete_game_button_2_Click(object sender, EventArgs e) { DeleteGame(2); }
        private void delete_game_button_3_Click(object sender, EventArgs e) { DeleteGame(3); }
        private void delete_game_button_4_Click(object sender, EventArgs e) { DeleteGame(4); }
        private void delete_game_button_5_Click(object sender, EventArgs e) { DeleteGame(5); }
        private void delete_game_button_6_Click(object sender, EventArgs e) { DeleteGame(6); }
        private void delete_game_button_7_Click(object sender, EventArgs e) { DeleteGame(7); }
        private void delete_game_button_8_Click(object sender, EventArgs e) { DeleteGame(8); }
        private void delete_game_button_9_Click(object sender, EventArgs e) { DeleteGame(9); }
        private void delete_game_button_10_Click(object sender, EventArgs e) { DeleteGame(10); }

        // --------------------------------------------------------------------------------------------------------------------------------


        public void DeleteGame(int number)
        {
            if (_savedGames.Count >= number && _savedGames[number] != null) // game exists
            {
                WfLogger.Log(this, LogLevel.DEBUG, $"Delete game number {number}");
                _savedGames.Remove(_savedGames[number]);
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
