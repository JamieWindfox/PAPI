using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    public partial class CreateNewGameView : PAPIView, ITranslatableView
    {
        // Players only added for Test, remove in release!!!!!
        private static Dictionary<Player, Button> removePlayerButtons = new Dictionary<Player, Button>();

        private static bool allComponentsAdded = false;

        public CreateNewGameView()
        {
            InitializeComponent();
            AddComponents();
        }


        private void AddComponents()
        {
            if(allComponentsAdded)
            {
                WfGLogger.Log(this.GetType() + ".AddComponents()", LogLevel.WARNING, "Stopped creating table, because it already was created");
                return;
            }
            playerListPanel.AutoSize = true;
            playerListPanel.ColumnCount = 2;
            playerListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            playerListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            playerListPanel.Controls.Add(playerNameText, 0, 0);
            playerListPanel.RowCount = 1;

            playerListPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;


            m_buttons.Add(cancelButton);
            m_buttons.Add(createGameButton);
            m_buttons.Add(addPlayerButton);
            SetButtonDesign();
            allComponentsAdded = true;
        }

        public void AddPlayer(Player player)
        {
            foreach(KeyValuePair<Player, Button> playerButton in removePlayerButtons)
            {
                if(playerButton.Key.m_name == player.m_name)
                {
                    WfGLogger.Log(this.GetType() + ".AddComponents()", LogLevel.WARNING, "Add player " + player.m_name + " not possible, there already is a player with the given name");
                    return;
                }
            }
            WfGLogger.Log(this.GetType() + ".AddComponents()", LogLevel.DEBUG, "Add player " + player.m_name + " to list of players");

            playerListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            playerListPanel.RowCount++;

            // Show name of player and put it into list
            playerListPanel.Controls.Add(new Label()
            {
                Text = player.m_name,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Width = 200
            }, 0, removePlayerButtons.Count+1);

            // Create formatted button
            Button button = new Button()
            {
                Text = "remove",
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(140, 40),
                Name = "removePlayerButton" + (removePlayerButtons.Count + 1)
            };

            playerListPanel.Controls.Add(button, 1, removePlayerButtons.Count + 1);
            m_buttons.Add(button);
            button.Click += RemovePlayerButton_Click;

            removePlayerButtons.Add(player, button);

            foreach (RowStyle rowStyle in playerListPanel.RowStyles)
            {
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 44;
            }

            SetButtonDesign();
        }

        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            string value = ((Button)sender).Name;
            Player playerToRemove = null;
            foreach(KeyValuePair<Player, Button> playerButton in removePlayerButtons)
            {
                if(playerButton.Value == (Button)sender)
                {
                    playerToRemove = playerButton.Key;
                }
            }
            if (playerToRemove != null)
            {
                WfGLogger.Log(this.GetType() + ".GameButtonClick(object, EventArgs)", LogLevel.DEBUG, "Remove Player " + playerToRemove.m_name);
            }
            else
            {
                WfGLogger.Log(this.GetType() + ".GameButtonClick(object, EventArgs)", LogLevel.WARNING, "For the given Button no player was found, who could be removed");
            }
            
        }

        

        public override void SetTextToActiveLanguage()
        {
            // TODO
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Caller = always Game Selection, their caller = always GM Start View
            m_caller.m_caller.Open(this);
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            PAPIPopup playerSearchPopup = new PlayerSearchPopup();
            playerSearchPopup.Popup(this);

            // TEST
            AddPlayer(new Player("Rainemof"));
        }
    }
}
