using GameMasterPAPI.Server;
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
    // The start view shows a welcome message with the Game masters' name, a "Quit" button, a "Start Game" button and an "Options" Button
    // This is where every session starts

    public partial class GMStartView : PAPIView
    {
        private string m_gmName;
        public GMStartView() : base()
        {
            InitializeComponent();
            Open();
            PAPIServer.Start();
        }

        // Set all text in this view to the given language
        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == GameSettings.GetLanguage() && m_gmName == CurrentPlayer.player.name)
            {
                return;
            }
            m_gmName = CurrentPlayer.player.name;

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, welcomeLabel);
                welcomeLabel.Text += ", " + m_gmName;
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
