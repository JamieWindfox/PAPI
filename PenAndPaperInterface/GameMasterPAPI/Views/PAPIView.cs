using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PAPI.Logging;
using PAPI.Settings;
using Microsoft.CodeAnalysis;
using PAPI.Exception;
using System.Resources;

namespace GameMasterPAPI.Views
{
    public partial class PAPIView : Form, ITranslatableView
    {
        public LanguageEnum activeLanguage { get; protected set; } = LanguageEnum.NOT_VALID;
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
                if(button.Text != "")
                {
                    button.Size = new Size(120, 40);
                }
                else
                {
                    button.Size = new Size(40, 40);
                }
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Button design was set to " + GameSettings._activeDesign);
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
            switch (GameSettings._activeDesign)
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
            WfLogger.Log(this, LogLevel.DEBUG, "Design was set to " + GameSettings._activeDesign);
            SetButtonDesign();
        }

        public virtual void SetTextToActiveLanguage()
        {
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        /*public virtual void Translate(ResXResourceSet resSet, Control control)
        {
            WfLogger.Log(this, LogLevel.WARNING, "Translate not implemented");
        }*/

        public string GetResourceFile()
        {
            string resFile;

            switch (GameSettings._activeLanguage)
            {
                case LanguageEnum.GERMAN:
                    resFile = @".\Strings\\General_DE.resx";
                    activeLanguage = LanguageEnum.GERMAN;
                    break;
                case LanguageEnum.ENGLISH:
                default:
                    resFile = @".\Strings\\General_EN.resx";
                    activeLanguage = LanguageEnum.ENGLISH;
                    break;
            }
            return resFile;
        }

        public void Translate(ResXResourceSet resSet, Control control)
        {
            string text = resSet.GetString(control.Name);
            if (text != null)
            {
                control.Text = resSet.GetString(control.Name);
            }
            else
            {
                control.Text = control.Name;
            }
        }

        public string TranslatedString(ResXResourceSet resSet, string key)
        {
            string text = resSet.GetString(key);
            if (text != null)
            {
                return text;
            }
            else
            {
                return key;
            }
        }

        public string RemoveNumbers(string text)
        {
            string output = text.Replace("0", "");
            output = output.Replace("1", "");
            output = output.Replace("2", "");
            output = output.Replace("3", "");
            output = output.Replace("4", "");
            output = output.Replace("5", "");
            output = output.Replace("6", "");
            output = output.Replace("7", "");
            output = output.Replace("8", "");
            output = output.Replace("9", "");
            return output;
        }
    }
}
