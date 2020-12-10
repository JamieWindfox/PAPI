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
    public partial class ShowGameOverviewPopup : PAPIPopup, ITranslatableView
    {
        public Game game { get; private set; }
        private GenreEnum shownGenre = GenreEnum.NOT_VALID;
        public ShowGameOverviewPopup()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized ShowGamePopup");
        }

        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == GameSettings.GetLanguage() && game != null && shownGenre == game.genre)
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, genreLabel);
                genreLabel.Text += ": " + TranslatedString(resSet, "genre_" + game.genre.ToString().ToLower());
                Translate(resSet, creationDateLabel);
                creationDateLabel.Text += ": " + game.dateOfCreation.ToString();
                Translate(resSet, lastSaveLabel);
                lastSaveLabel.Text += ": " + game.lastSession.ToString();
            }
        }

        public void Popup(PAPIView caller, Game game)
        {
            this.game = game;
            Popup(caller);
            WfLogger.Log(this, LogLevel.DEBUG, "Inherited Popup was called...");
            m_buttons.Add(cancelButton);
            m_buttons.Add(deleteButton);
            m_buttons.Add(startButton);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Cancel' Button was clicked, Popup closes");
            Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "'Delete' Button was clicked, 'Are you sure?' Prompt opens");
            DeleteGamePromptPopup areYouSurePromt = new DeleteGamePromptPopup();
            areYouSurePromt.Popup(this);
        }
    }
}
