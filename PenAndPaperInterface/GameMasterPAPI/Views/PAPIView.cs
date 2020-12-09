﻿using System;
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
        public Language activeLanguage { get; protected set; } = Language.NOT_VALID;
        public List<Button> m_buttons { get; protected set; }


        public PAPIView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");

            m_buttons = new List<Button>();
            
            WfLogger.Log(this, LogLevel.DEBUG, "Created new View");
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
            WfLogger.Log(this, LogLevel.DEBUG, "Button design was set to " + GameSettings.GetDesign());
        }

        public void Open(PAPIView caller)
        {
            ViewController.lastView = caller;
            ViewController.curentlyOpenView = this;
            if (caller != null)
            {
                caller.Hide();
                this.Location = caller.Location;
                this.Size = caller.Size;
            }

            SetDesign();
            SetButtonDesign();
            SetTextToActiveLanguage();
            Show();
            WfLogger.Log(this, LogLevel.DEBUG, "Opened View" + this.GetType().ToString());
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
            if (ViewController.lastView != null)
            {
                Location = ViewController.lastView.Location;
                Size = ViewController.lastView.Size;
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
            WfLogger.Log(this, LogLevel.DEBUG, "Design was set to " + GameSettings.GetDesign());
            SetButtonDesign();
        }

        public virtual void SetTextToActiveLanguage()
        {
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        public virtual void Translate(ref List<Control> controls, bool translatewSameLanguage)
        {
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }
    }
}
