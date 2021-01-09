using PAPI.Logging;
using PAPI.Settings.Game;
using System;
using System.Drawing;
using System.Resources;

namespace PAPIClient.Views
{
    public partial class DeleteGamePromptPopup : PAPIPopup, ITranslatableView
    {
        /// <summary>
        /// Pops up if the player clicks on the 'delete' button of a game
        /// </summary>
        public DeleteGamePromptPopup()
        {
            InitializeComponent();
            Size = new Size(400, 200);
        }

        /// <summary>
        /// Sets all text in the popup to the selected language
        /// </summary>
        public override void SetTextToActiveLanguage()
        {
            if (_shownLanguage == PAPIApplication.GetLanguage())
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, deleteGameQuestionLabel);
                Translate(resSet, yesButton);
                Translate(resSet, noButton);                
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Deletes the selected game if clicked
        /// </summary>
        private void yesButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Yes' Button was clicked, game is being deleted");
            ((GameSelectionView)(ViewController.gameSelectionView)).DeleteGame(PAPIApplication._runningGame);
            PAPIApplication._runningGame.ClearGame();
            ViewController.showGameOverviewView.Hide();
            ViewController.gameSelectionView.Open(ViewController.startView);
            Hide();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns from the Popup without deleting the selected game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'No' Button was clicked, game remains saved");
            ViewController.gameSelectionView.Open(ViewController.startView);
            Hide();
        }
    }
}
