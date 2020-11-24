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
    public partial class SettingsView : PAPIForm
    {
        public SettingsView() : base()
        { }

        public SettingsView(Form caller) : base(caller)
        { }

        public override void Init()
        {
            InitializeComponent();
        }
    }
}
