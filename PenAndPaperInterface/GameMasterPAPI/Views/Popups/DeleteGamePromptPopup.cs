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
            if (activeLanguage == GameSettings.GetLanguage())
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, deleteGameQuestionLabel);
                Translate(resSet, yesButton);
                Translate(resSet, noButton);                
            }
        }

        /// <summary>
        /// Deletes the selected game if clicked
        /// </summary>
        private void yesButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Yes' Button was clicked, game is being deleted");
            ((GameSelectionView)(ViewController.gameSelectionView)).DeleteGame(RunningGame.game);
            RunningGame.ClearGame();
            ViewController.showGameOverviewView.Hide();
            ViewController.gameSelectionView.Open(ViewController.startView);
            Hide();
        }

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
