
using PAPIClient.Server;
using PAPIClient.Views;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PAPIClient
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
            Application.Run(ViewController.Start());
        }
    }
}
