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
    public partial class GMStartView : PAPIView, IPAPIView
    {
        public GMStartView()
        {
            Init();
        }

        public void Init()
        {
            InitializeComponent();
            SetTextToActiveLanguage();
            m_isOpen = true;
        }

        public void SetTextToActiveLanguage()
        {
            if (m_activeLanguage == GameSettings.GetLanguage() && m_isOpen)
            {
                return;
            }
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
                welcomeText.Text = resSet.GetString("welcome") + ", " + GameSettings.GetGmName();
                quitButton.Text = resSet.GetString("quit");
                startGameButton.Text = resSet.GetString("startGame");
                optionsButton.Text = resSet.GetString("options");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            GMOptionsView optionsView = new GMOptionsView(this);
            Hide();
            m_isOpen = false;
            optionsView.Open();
        }

        
    }
}
