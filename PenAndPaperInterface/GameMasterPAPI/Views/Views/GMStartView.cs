using GameMasterPAPI.Server;
using PAPI.Settings.Game;
using System;
using System.Resources;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    // The start view shows a welcome message with the Game masters' name, a "Quit" button, a "Start Game" button and an "Options" Button
    // This is where every session starts

    public partial class GMStartView : PAPIView
    {
        private string _playerName;
        public GMStartView() : base()
        {
            InitializeComponent();
            Open();
            PAPIServer.Start();
        }

        // Set all text in this view to the given language
        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == PAPIApplication.GetLanguage() && _playerName == PAPIApplication._currentPlayer._name)
            {
                return;
            }
            _playerName = PAPIApplication._currentPlayer._name;

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, welcomeLabel);
                welcomeLabel.Text += ", " + _playerName;
                Translate(resSet, quitButton);
                Translate(resSet, startButton);
                Translate(resSet, optionsButton);
            }
        }

        // Shuts down the application
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Opens the options view
        private void optionsButton_Click(object sender, EventArgs e)
        {
            GMOptionsView optionsView = new GMOptionsView();
            optionsView.Open(this);
        }

        // Opens the Game Overview
        private void startButton_Click(object sender, EventArgs e)
        {
            GameSelectionView createGameView = new GameSelectionView();
            createGameView.Open(this);
        }

        public void Open()
        {
            base.Open(null);
        }
    }
}
