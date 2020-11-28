using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAPI.Logging;
using PAPI.Settings;

namespace GameMasterPAPI.Views
{
    public partial class PAPIView : Form
    {
        protected PAPIView m_caller;
        protected Language m_activeLanguage = Language.ENGLISH;
        protected bool m_isOpen = false;

        public PAPIView()
        {
            InitBase();
            m_caller = null;
        }

        public PAPIView(PAPIView caller)
        {
            InitBase();
            m_caller = caller;
            this.Location = caller.Location;
            this.Size = caller.Size;
        }

        public void InitBase()
        {
            InitializeComponent();
            SetDesign();
        }

        protected void SetDesign()
        {
            if (m_caller == null) m_caller = this;
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
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.Manual;
            Location = m_caller.Location;
            Size = m_caller.Size;
            WindowState = FormWindowState.Normal;
            MaximizeBox = true;
            MinimizeBox = true;
            ShowIcon = false;
            ShowInTaskbar = true;
            AutoScaleMode = AutoScaleMode.None;
            ControlBox = true;
        }

        protected void SetButtonDesign(List<Button> buttons)
        {
            foreach(Button button in buttons)
            {
                button.BackColor = BackColor;
                button.ForeColor = ForeColor;
                button.FlatStyle = FlatStyle.Flat;
                button.Size = new Size(120, 40);
            }
        }

        public void Open()
        {
            SetDesign();
            SetTextToActiveLanguage();
        }

        private void SetTextToActiveLanguage()
        {
            string excMsg = "Tried to set language of non-existing form, there must not be a super class PAPIView!";
            WfGLogger.Log(this.GetType() + ".SetTextToActiveLanguage()", LogLevel.FATAL, excMsg);
            throw new NotImplementedException(excMsg);
        }
    }
}
