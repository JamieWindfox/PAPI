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
        }

        // Set all text in this view to the given language
        public override void SetTextToActiveLanguage()
        {
            
            if (m_activeLanguage == GameSettings.GetLanguage() && m_gmName == GameSettings.GetGm().m_name)
            {
                return;
            }
            m_gmName = GameSettings.GetGm().m_name;
            string resFile;

            switch (GameSettings.GetLanguage())
            {
                case Language.GERMAN:
                    resFile = @".\Strings\\General_DE.resx";
                    m_activeLanguage = Language.GERMAN;
                    break;
                case Language.ENGLISH:
                default:
                    resFile = @".\Strings\\General_EN.resx";
                    m_activeLanguage = Language.ENGLISH;
                    break;
            }
            using (ResXResourceSet resSet = new ResXResourceSet(resFile))
            {
                welcomeText.Text = resSet.GetString("welcome") + ", " + m_gmName;
                quitButton.Text = resSet.GetString("quit");
                startGameButton.Text = resSet.GetString("startGame");
                optionsButton.Text = resSet.GetString("options");
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
            GMOptionsView optionsView = new GMOptionsView(this);
            optionsView.Open(this);
        }

        // Opens the Game Overview
        private void startGameButton_Click(object sender, EventArgs e)
        {
            SelectGameView createGameView = new SelectGameView();
            createGameView.Open(this);
        }
    }
}
