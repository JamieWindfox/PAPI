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
    public partial class ShowGameOverviewPopup : PAPIPopup, ITranslatableView
    {
        public ShowGameOverviewPopup()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized ShowGamePopup");
        }

        public override void SetTextToActiveLanguage()
        {
            // TODO
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        
    }
}
