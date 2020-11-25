using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    public partial class GMLoadingView : PAPIView
    {
        PAPIView m_caller;

        public GMLoadingView(PAPIView caller) : this()
        {
            m_caller = caller;
            returnButton.Visible = true;
            returnButton.Dock = DockStyle.Bottom | DockStyle.Left;
            SetButtonDesign(new List<Button>() { returnButton, acceptButton});
        }
        public GMLoadingView() : base()
        {
            InitializeComponent();
            SetTextToActiveLanguage();
            languageText.Dock = DockStyle.Top | DockStyle.Left;
            designText.Dock = DockStyle.Top | DockStyle.Left;
            m_caller = null;
            returnButton.Visible = false;

            acceptButton.Dock = DockStyle.Right;
            SetButtonDesign(new List<Button>() { acceptButton });
        }

        private void SetTextToActiveLanguage()
        {
            switch(GameSettings.GetLanguage())
            {
                case Language.GERMAN:
                    languageText.Text = "Sprache";
                    designText.Text = "Design";
                    designDropdown.Items[0] = "Mittelalterlich";
                    designDropdown.Items[1] = "Modern";
                    returnButton.Text = "Zurück";
                    acceptButton.Text = "Weiter";
                    break;
                case Language.ENGLISH:
                default:
                    languageText.Text = "Language";
                    designText.Text = "Design";
                    designDropdown.Items[0] = "Medieval";
                    designDropdown.Items[1] = "Modern";
                    returnButton.Text = "Return";
                    acceptButton.Text = "Accept";
                    break;
            }
        }

        private void languageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(languageDropdown.SelectedItem.ToString())
            {
                case "English": GameSettings.SetActiveLanguage(Language.ENGLISH);
                    break;
                case "Deutsch": GameSettings.SetActiveLanguage(Language.GERMAN);
                    break;
                default: GameSettings.SetActiveLanguage(Language.ENGLISH);
                    break;
            }
            SetTextToActiveLanguage();
        }

        private void designDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (designDropdown.SelectedIndex)
            {
                case 0:
                    GameSettings.SetActiveDesign(DesignEnum.MEDIEVAL);
                    break;
                case 1:
                    GameSettings.SetActiveDesign(DesignEnum.MODERN);
                    break;
                default:
                    GameSettings.SetActiveDesign(DesignEnum.MODERN);
                    break;
            }
            SetDesign();
        }
    }
}
