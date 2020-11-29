using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PAPI.Logging;
using PAPI.Settings;
using Microsoft.CodeAnalysis;
using PAPI.Exception;

namespace GameMasterPAPI.Views
{
    public partial class PAPIView : Form, ITranslatableView
    {
        public PAPIView m_caller { get; protected set; }
        public Language m_activeLanguage { get; protected set; } = Language.NOT_VALID;
        public List<Button> m_buttons { get; protected set; }

        public PAPIView() : this(null)
        { }

        public PAPIView(PAPIView caller)
        {
            InitializeComponent();
            m_caller = caller;
            if (m_caller != null)
            {
                this.Location = m_caller.Location;
                this.Size = m_caller.Size;
            }
            m_buttons = new List<Button>();
        }

        protected void SetButtonDesign()
        {
            foreach(Button button in m_buttons)
            {
                button.BackColor = BackColor;
                button.ForeColor = ForeColor;
                button.FlatStyle = FlatStyle.Flat;
                button.Size = new Size(120, 40);
            }
        }

        public void Open(PAPIView caller)
        {
            if (caller != null)
            {
                m_caller = caller;
                caller.Hide();
            }
            SetDesign();
            SetButtonDesign();
            SetTextToActiveLanguage();
            Show();
        }
        public void Open()
        {
            Open(null);
        }

        protected void SetDesign()
        {
            switch (GameSettings.GetDesign())
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
            if (m_caller != null)
            {
                Location = m_caller.Location;
                Size = m_caller.Size;
            }
            else
            {
                Location = new Point(0, 0);
                Size = new Size(800, 600);
            }
            WindowState = FormWindowState.Normal;
            MaximizeBox = true;
            MinimizeBox = true;
            ShowIcon = false;
            ShowInTaskbar = true;
            AutoScaleMode = AutoScaleMode.None;
            ControlBox = true;
            SetButtonDesign();
        }

        public virtual void SetTextToActiveLanguage()
        {
            string excMsg = "Not implemented for PAPIView";
            WfGLogger.Log(this.GetType() + ".SetTextToActiveLanguage()", LogLevel.ERROR, excMsg);
            throw new PAPIException(excMsg);
        }
    }
}
