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

        }

        public override void SetTextToActiveLanguage()
        {
            string excMsg = "Only for inherited classes of PAPIPopp";
            WfGLogger.Log(this.GetType() + "SetTextToActiveLanguage()", LogLevel.ERROR, excMsg);
            throw new NotImplementedException(excMsg);
        }

        public void Popup(PAPIView parent)
        {
            if (parent != null)
            {
                m_caller = parent;
            }
            SetDesign();
            SetButtonDesign();
            SetTextToActiveLanguage();
            Show();
        }
    }
}
