using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPIClient.Views
{
    public partial class PAPIPopup : PAPIView
    {
        public PAPIPopup()
        {
            //WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
        }

        public override void SetTextToActiveLanguage()
        {
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        public void Popup(PAPIView parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                ViewController.lastView = parent;
                WfLogger.Log(this, LogLevel.DEBUG, "Open Popup from parent " + parent.GetType());
            }
            SetDesign();
            SetButtonDesign();
            SetTextToActiveLanguage();
            Size = new Size((int)((double)Width * 0.8), (int)((double)Height * 0.8));
            ShowDialog();
        }

        public void Open()
        {
            throw new NotImplementedException("Method 'Open()' is not valid for a Popup, use 'Popup(this)' instead!");
        }
    }
}
