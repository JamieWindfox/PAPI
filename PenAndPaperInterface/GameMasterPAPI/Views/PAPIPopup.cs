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

namespace GameMasterPAPI.Views
{
    public partial class PAPIPopup : PAPIView
    {
        public PAPIPopup()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
        }

        public override void SetTextToActiveLanguage()
        {
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        public void Popup(PAPIView parent)
        {
            
            if (parent != null)
            {
                m_caller = parent;
                WfLogger.Log(this, LogLevel.DEBUG, "Open Popup from parent " + parent.GetType());
            }
            SetDesign();
            SetButtonDesign();
            SetTextToActiveLanguage();
            Size = new Size((int)((double)Width * 0.8), (int)((double)Height * 0.8));
            Show();
        }
    }
}
