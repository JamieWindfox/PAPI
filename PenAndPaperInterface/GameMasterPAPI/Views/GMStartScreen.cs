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
    public partial class GMStartScreen : PAPIForm
    {
        public GMStartScreen() : base()
        { }

        public GMStartScreen(Form caller) : base(caller)
        { }

        public override void Init()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsView settingsView =  new SettingsView();
            this.Hide();
            settingsView.Show();
        }
    }
}
