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
    public partial class PAPIForm : Form
    {
        Form m_caller;

        public PAPIForm() : this(null)
        { }
        public PAPIForm(Form caller)
        {
            m_caller = caller;

            Init();
        }

        public virtual void Init() { }

        private void SetFormFullScreen()
        {
            System.Drawing.Rectangle workingRectangle =
            Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(workingRectangle.Width, workingRectangle.Height);
            this.Location = new System.Drawing.Point(0, 0);
        }
    }
}
