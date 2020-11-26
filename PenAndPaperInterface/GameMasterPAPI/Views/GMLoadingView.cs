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
using System.Resources;

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

            acceptButton.Dock = DockStyle.Bottom;
            SetDesign();
            SetButtonDesign(new List<Button>() { acceptButton });
        }

        private void SetTextToActiveLanguage()
        {
            string resFile;

            switch (GameSettings.GetLanguage())
            {
                case Language.GERMAN:
                    resFile = @".\Strings\\General_DE.resx";
                    break;
                case Language.ENGLISH:
                default:
                    resFile = @".\Strings\\General_EN.resx";
                    break;
            }
            using (ResXResourceSet resSet = new ResXResourceSet(resFile))
            {
                languageText.Text = resSet.GetString("language");
                designText.Text = resSet.GetString("design");
                designDropdown.Items[0] = resSet.GetString("medieval");
                designDropdown.Items[1] = resSet.GetString("modern");
                languageDropdown.Items[0] = resSet.GetString("english");
                languageDropdown.Items[1] = resSet.GetString("german");
                returnButton.Text = resSet.GetString("return");
                acceptButton.Text = resSet.GetString("accept");
            }
        }

        private void languageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(languageDropdown.SelectedIndex)
            {
                case 0:
                    GameSettings.SetActiveLanguage(Language.ENGLISH);
                    break;
                case 1:
                    GameSettings.SetActiveLanguage(Language.GERMAN);
                    break;
                default:
                    GameSettings.SetActiveLanguage(Language.ENGLISH);
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
            SetButtonDesign(new List<Button>() { acceptButton, returnButton });
        }
    }
}
