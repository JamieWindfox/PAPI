using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterPAPI.Views
{
    public static class ViewController
    {
        // Views
        public static PAPIView startView { get; } = new GMStartView();
        public static PAPIView optionsView { get; } = new GMOptionsView();
        public static PAPIView gameSelectionView { get; } = new GameSelectionView();
        public static PAPIView gameCreationView { get; } = new GameCreationView();
        public static PAPIView gameView { get; } = new GameView();

        // Popups
        static public PAPIPopup playerSearchPopup { get; } = new PlayerSearchPopup();
        static public PAPIView showGameOverviewView { get; } = new ShowGameOverviewView();

        // Currently open
        public static PAPIView curentlyOpenView { get; set; } = startView;

        // Last open view
        public static PAPIView lastView { get; set; } = null;

        public static PAPIView Start()
        {
            ((GMStartView)startView).Open();
            return startView;
        }

    }
}
