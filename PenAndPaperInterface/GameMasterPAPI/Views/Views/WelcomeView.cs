using PAPIClient.Server;
using PAPI.Settings.Game;
using System;
using System.Resources;
using System.Windows.Forms;

namespace PAPIClient.Views
{
    /// <summary>
    /// The start view shows a welcome message with the player name, a "Quit" button, a "Start Game" button and an "Options" Button
    /// This is where every session starts
    /// </summary>
    public partial class WelcomeView : PAPIView
    {
        private string _playerName;


        public WelcomeView() : base()
        {
            InitializeComponent();
            Open();
            PAPIServer.Start();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Set all text in this view to the language which was set in the settings
        /// </summary>
        public override void SetTextToActiveLanguage()
        {
            if (_shownLanguage == PAPIApplication.GetLanguage() && _playerName == PAPIApplication.GetPlayer()._name)
            {
                return;
            }
            _playerName = PAPIApplication.GetPlayer()._name;

            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, welcome_label);
                welcome_label.Text += ", " + _playerName;
                Translate(resSet, quit_button);
                Translate(resSet, start_button);
                Translate(resSet, options_button);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        // Shuts down the application
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        // Opens the options view
        private void optionsButton_Click(object sender, EventArgs e)
        {
            GMOptionsView optionsView = new GMOptionsView();
            optionsView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        // Opens the Game Overview
        private void startButton_Click(object sender, EventArgs e)
        {
            StartView startView = new StartView();
            startView.Open(this);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public void Open()
        {
            base.Open(null);
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
