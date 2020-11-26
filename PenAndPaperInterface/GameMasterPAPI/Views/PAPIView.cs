using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAPI.Settings;

namespace GameMasterPAPI.Views
{
    public partial class PAPIView : Form
    {
        protected PAPIView m_caller;
        public PAPIView()
        {
            InitializeComponent();
            SetDesign();
            m_caller = null;
        }

        public PAPIView(PAPIView caller)
        {
            InitializeComponent();
            SetDesign();
            m_caller = caller;
        }

        protected void SetDesign()
        {
            switch(GameSettings.GetDesign())
            {
                case DesignEnum.MEDIEVAL:
                    BackColor = System.Drawing.Color.AntiqueWhite;
                    ForeColor = System.Drawing.Color.Black;
                    Font = new Font("Papyrus", 12, FontStyle.Bold);
                    break;
                case DesignEnum.MODERN:
                    BackColor = System.Drawing.Color.Black;
                    ForeColor = System.Drawing.Color.Lime;
                    Font = new Font("Consolas", 12);
                    break;
                default:
                    BackColor = System.Drawing.Color.White;
                    ForeColor = System.Drawing.Color.Black;
                    Font = new Font("Calibri", 12);
                    break;
            }
            Size = new Size(800, 600);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        protected void SetButtonDesign(List<Button> buttons)
        {
            foreach(Button button in buttons)
            {
                button.BackColor = BackColor;
                button.ForeColor = ForeColor;
                button.FlatStyle = FlatStyle.Flat;
            }
        }
    }
}
