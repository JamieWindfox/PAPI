using GameMasterPAPI.Server;
using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    public partial class PlayerSearchPopup : PAPIPopup, ITranslatableView
    {
        private uint attemptCounter = 10;
        private const uint MAX_SEARCH_TIME = 10;
        public PlayerSearchPopup()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
        }

        public override void SetTextToActiveLanguage()
        {
            // TODO
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        private void SearchPlayer()
        {
            while (attemptCounter < MAX_SEARCH_TIME)
            { 
                if (PendingMessages.waitingPlayers.Count > 0)
                {
                    WfLogger.Log(this, LogLevel.DEBUG, "Pending Player Requests found: " + PendingMessages.waitingPlayers.Count);
                    AddPlayer(PendingMessages.waitingPlayers[0]);
                    return;
                }
                else
                {
                    WfLogger.Log(this, LogLevel.DEBUG, "No Pending Player Requests found... trying again (Attempt number: " + attemptCounter + ")");
                    Thread.Sleep(1000);
                    attemptCounter++;
                    SearchPlayer();
                    return;
                }
            }
        }

        private void AddPlayer(Player player)
        {
            ((GameCreationView)ViewController.gameCreationView).AddPlayer(player);
            this.foundPlayerName.Text = PendingMessages.waitingPlayers[0].name;
            PendingMessages.waitingPlayers.RemoveAt(0);
        }

        private void searchPlayerButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "search Player Button was clicked, searching for pending player requests...");
            attemptCounter = 0;
            SearchPlayer();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Cancel Button was clicked, Popup closes");
            this.Hide();
        }
    }
}
