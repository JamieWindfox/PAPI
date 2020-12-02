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
    public partial class GMOptionsView : PAPIView
    {
        private string m_gmName;
        public GMOptionsView(PAPIView caller) : base(caller)
        {
            InitializeComponent();
            m_buttons.Add(returnButton);
            SetButtonDesign();
        }


        public override void SetTextToActiveLanguage()
        {
            if(m_activeLanguage == GameSettings.GetLanguage() && m_gmName == GameSettings.GetGm().m_name)
            {
                return;
            }
            m_gmName = GameSettings.GetGm().m_name;
            gmNameInputField.Text = m_gmName;
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
                languageText.Text = resSet.GetString("language");
                designText.Text = resSet.GetString("design");
                designDropdown.Items[0] = resSet.GetString("medieval");
                designDropdown.Items[1] = resSet.GetString("modern");
                languageDropdown.Items[0] = resSet.GetString("english");
                languageDropdown.Items[1] = resSet.GetString("german");
                returnButton.Text = resSet.GetString("return");
                gmName.Text = resSet.GetString("gmName");
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
            SetButtonDesign();
        }

        private void gmNameInputField_TextChanged(object sender, EventArgs e)
        {
            GameSettings.SetGmName(gmNameInputField.Text);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            m_caller.Open(this);
        }
    }
}
