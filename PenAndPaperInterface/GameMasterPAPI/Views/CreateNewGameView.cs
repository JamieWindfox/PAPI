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

        private static GenreEnum selectedGenre = GenreEnum.NOT_VALID;

        public CreateNewGameView()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            AddComponents();
            createGameButton.Enabled = false;
        }


        private void AddComponents()
        {
            if(allComponentsAdded)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Stopped creating table, because it already has been created before");
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
            WfLogger.Log(this, LogLevel.DEBUG, "Added all components");
        }

        public void AddPlayer(Player player)
        {
            foreach(KeyValuePair<Player, Button> playerButton in removePlayerButtons)
            {
                if(playerButton.Key.m_name == player.m_name)
                {
                    WfLogger.Log(this, LogLevel.WARNING, "Add player " + player.m_name + " not possible, there already is a player with this name");
                    return;
                }
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Add player " + player.m_name + " to list of players");

            playerListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            playerListPanel.RowCount++;

            // Show name of player and put it into list
            playerListPanel.Controls.Add(new Label()
            {
                Text = player.m_name,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Width = 200
            }, 0, removePlayerButtons.Count+1);

            // Create formatted button and its functionality
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

            // Set all rows to same size
            foreach (RowStyle rowStyle in playerListPanel.RowStyles)
            {
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 44;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Added player " + player.m_name);
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
                WfLogger.Log(this, LogLevel.DEBUG, "Remove Player " + playerToRemove.m_name);
            }
            else
            {
                WfLogger.Log(this, LogLevel.WARNING, "For the given Button no player was found, who could be removed");
            }
            
        }

        public override void SetTextToActiveLanguage()
        {
            // TODO
            WfLogger.Log(this, LogLevel.WARNING, "SetTextToActiveLanguage not implemented");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Caller = always Game Selection, their caller = always GM Start View
            WfLogger.Log(this, LogLevel.DEBUG, "Cancel Button was clicked, return to GMStartView");
            m_caller.m_caller.Open(this);
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Add new Player Button was clicked, open the Player Search Popup");
            PAPIPopup playerSearchPopup = new PlayerSearchPopup();
            playerSearchPopup.Popup(this);

            // TEST
            AddPlayer(new Player("Rainemof"));
        }

        private void genreDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (genreDropdown.SelectedIndex)
            {
                case 0:
                    selectedGenre = GenreEnum.NUCLEAR_FALLOUT;
                    break;
                case 1:
                    selectedGenre = GenreEnum.MEDIEVAL_FANTASY;
                    break;
                case 2:
                    selectedGenre = GenreEnum.MAGICAL_WORLD;
                    break;
                case 3:
                    selectedGenre = GenreEnum.SPACE_OPERA;
                    break;
                default:
                    selectedGenre = GenreEnum.NOT_VALID;
                    break;
            }
            if(selectedGenre != GenreEnum.NOT_VALID)
            {
                createGameButton.Enabled = true;
            }
            WfLogger.Log(this, LogLevel.DEBUG, "Genre " + selectedGenre + " was selected in dropdown");
            SetTextToActiveLanguage();
        }

        private void createGameButton_Click(object sender, EventArgs e)
        {
            if (selectedGenre != GenreEnum.NOT_VALID)
            {
                RunningGame.StartGame(new Game(selectedGenre));
                WfLogger.Log(this, LogLevel.DEBUG, "Create Game Button clicked, created a new Game (" + selectedGenre + ")");
                foreach(KeyValuePair<Player, Button> playerButton in removePlayerButtons)
                {
                    RunningGame.game.AddPlayer(playerButton.Key);
                }
                
            }
        }
    }
}
