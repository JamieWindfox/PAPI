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
    public partial class StartView : PAPIView
    {
        /// <summary>
        /// The start view shows all functions a player has:
        /// * Games
        /// * Characters
        /// * Vehicles
        /// * Buildings
        /// * Items
        /// </summary>
        public StartView() : base()
        {
            InitializeComponent();

            //_buttons.Add();
            SetButtonDesign();
        }
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Set all text in this view to the language which was set in the settings
        /// </summary>
        public override void SetTextToActiveLanguage()
        {
            // TODO
        }

        // --------------------------------------------------------------------------------------------------------------------------------



        // --------------------------------------------------------------------------------------------------------------------------------



        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
