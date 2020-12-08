
using GameMasterPAPI.Server;
using GameMasterPAPI.Views;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GameMasterPAPI
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GMStartView());
        }
    }
}
