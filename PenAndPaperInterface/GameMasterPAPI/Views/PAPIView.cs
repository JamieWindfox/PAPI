using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PAPI.Logging;
using PAPI.Settings;
using System.Resources;
using PAPI.Settings.Game;

namespace PAPIClient.Views
{
    public partial class PAPIView : Form, ITranslatableView
    {
        public LanguageEnum _shownLanguage { get; protected set; } = LanguageEnum.NOT_VALID;
        public List<Button> _buttons { get; protected set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        public PAPIView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");

            _buttons = new List<Button>();
            
            WfLogger.Log(this, LogLevel.DEBUG, "Created new View");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the desisgn of the buttons to the same as the view
        /// </summary>
        protected void SetButtonDesign()
        {
            foreach(Button button in _buttons)
            {
                button.BackColor = BackColor;
                button.ForeColor = ForeColor;
                button.FlatStyle = FlatStyle.Flat;
                if(button.Text != "")
                {
                    button.Size = new Size(200, 40);
                }
                else
                {
                    button.Size = new Size(40, 40);
                }
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Button design was set to " + PAPIApplication.GetDesign());
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Opens the view and hides the caller
        /// </summary>
        /// <param name="caller"></param>
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

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the design of the view to the one, that was set in the settings
        /// </summary>
        protected void SetDesign()
        {
            switch (PAPIApplication.GetDesign())
            {
                case DesignEnum.BLACK_ON_ANTIQUE:
                    BackColor = System.Drawing.Color.AntiqueWhite;
                    ForeColor = System.Drawing.Color.Black;
                    Font = new Font("Papyrus", 12, FontStyle.Bold);
                    break;
                case DesignEnum.GREEN_ON_BLACK:
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
            WfLogger.Log(this, LogLevel.DEBUG, "Design was set to " + PAPIApplication.GetDesign());
            SetButtonDesign();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Translates all text on the view to the language that was set in the settings
        /// </summary>
        public virtual void SetTextToActiveLanguage()
        {
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented for the super class PAPIView");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns the filepath of the translation file (Language from settings)
        /// </summary>
        /// <returns></returns>
        public string GetTranslationFile()
        {
            string resFile = GameDirectory.GetTranslationFile(PAPIApplication.GetLanguage());
            return resFile;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Translates a control from it's name
        /// </summary>
        /// <param name="resSet"></param>
        /// <param name="control"></param>
        public string Translate(ResXResourceSet resSet, Control control)
        {
            string textToTranslate = "Translation_" + control.Name.ToUpper();
            string text = resSet.GetString(textToTranslate);
            if (text != null)
            {
                control.Text = text;
            }
            else
            {
                control.Text = control.Name;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Translated " + control.Name + " to " + control.Text
                + " (Language = " + PAPIApplication.GetLanguage() + ")");

            return control.Text;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Translates a string
        /// </summary>
        /// <param name="resSet"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string TranslatedString(ResXResourceSet resSet, string key)
        {
            string text = resSet.GetString("Translation_" + key.ToUpper());
            if (text != null)
            {
                return text;
            }
            else
            {
                return key;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Translates a string
        /// </summary>
        /// <param name="resSet"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string TranslatedEnum(ResXResourceSet resSet, Enum enumValue)
        {
            string key = EnumConverter.Convert(enumValue);
            string text = resSet.GetString(key);
            if (text != null && text != "")
            {
                return text;
            }
            else
            {
                return key;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Copies the given strings, but removed the numbers form it
        /// </summary>
        /// <param name="text">if null or empty, nothing happens</param>
        /// <returns>The given stirng without numbers</returns>
        public string RemoveNumbers(string text)
        {
            if (text == null || text == "") return text;

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

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
