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
    public partial class GMStartMenuView : PAPIView
    {
        
        public GMStartMenuView(PAPIView caller) : base(caller)
        {
            MdiParent = caller.MdiParent;
            InitializeComponent();
            test();
        }

        public void test()
        {
            welcomeText.Text = "Hello World";
            welcomeText.Visible = true;
            welcomeText.ForeColor = System.Drawing.Color.White;
        }

    }
}
