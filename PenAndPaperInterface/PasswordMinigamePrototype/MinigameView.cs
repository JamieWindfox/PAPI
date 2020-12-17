using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameMasterPAPI.Views;

namespace PasswordMinigamePrototype
{
    public partial class MinigameView : PAPIView
    {
        public MinigameView()
        {
            this.Size = new Size(800, 600);
            InitializeComponent();
            
        }
    }
}
