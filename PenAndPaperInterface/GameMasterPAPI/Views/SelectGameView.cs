using PAPI.Settings;
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
    public partial class SelectGameView : PAPIView, ITranslatableView
    {
        // List of games for test, remove when permanent save games are implementes
        private static List<Game> savedGames = new List<Game>() { { new Game(GenreEnum.POSTNUKLEAR_FALLOUT) } };

        private uint m_page = 1;
        private static uint m_numberOfGames = 3;
        private const uint GAMES_PER_PAGE = 8;
        private List<TableLayoutPanel> m_sessionRows;
        public SelectGameView()
        {
            InitializeComponent();
            AddComponents();
        }

        public SelectGameView(PAPIView caller) : base(caller)
        {
            InitializeComponent();
            AddComponents();
        }

        private void AddComponents()
        {
            m_sessionRows = new List<TableLayoutPanel>();
            for(int i = 0; i < m_numberOfGames; ++i)
            {
                m_sessionRows.Add(new TableLayoutPanel());
                m_sessionRows[i].ColumnCount = 4;
                m_sessionRows[i].RowCount = 1;
                m_sessionRows[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                m_sessionRows[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f));
                m_sessionRows[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                m_sessionRows[i].ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
                m_sessionRows[i].RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                m_sessionRows[i].Controls.Add(new Label() { Text = savedGames[i].m_genre.ToString() }, 1, i+1);
                m_sessionRows[i].Controls.Add(new Label() { Text = savedGames[i].partyToString() }, 2, i+1);
                m_sessionRows[i].Controls.Add(new Label() { Text = savedGames[i].m_lastSession.ToString()}, 3, i+1);
                Button button = new Button()
                {
                    Text = "startSession",
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Fill,
                };
                m_sessionRows[i].Controls.Add(button, 4, 0);
            }

            m_buttons.Add(returnButton);
            m_buttons.Add(newGameButton);
            m_buttons.Add(previousPageButton);
            m_buttons.Add(nextPageButton);

            

            
            SetButtonVisibility();
            SetButtonDesign();
        }

        private void SetButtonVisibility()
        {
            if (m_numberOfGames <= GAMES_PER_PAGE)
            {
                previousPageButton.Visible = false;
                nextPageButton.Visible = false;
            }
            else if (m_page == m_numberOfGames / GAMES_PER_PAGE)
            {
                nextPageButton.Visible = false;
            }
            else if (m_page == 1)
            {
                previousPageButton.Visible = false;
            }
        }

        public override void SetTextToActiveLanguage()
        {
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            m_caller.Open(this);
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("This should show the previous page of saved games");
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("This should show the next page of saved games");
        }
    }
}
