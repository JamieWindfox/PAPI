using PAPI.Settings.Game;

namespace PAPIClient.Views
{
    /// <summary>
    /// Controls the opening and closing af the views
    /// </summary>
    public static class ViewController
    {
        // Views
        public static PAPIView welcomeView { get; } = new WelcomeView();
        public static PAPIView startView { get; } = new StartView();
        public static PAPIView optionsView { get; } = new GMOptionsView();
        public static PAPIView gameSelectionView { get; } = new GameSelectionView();
        public static PAPIView gameCreationView { get; } = new GameCreationView();
        

        // Popups
        static public PAPIPopup playerSearchPopup { get; } = new PlayerSearchPopup();
        static public PAPIView showGameOverviewView { get; } = new ShowGameOverviewView();

        // Currently open
        public static PAPIView curentlyOpenView { get; set; } = startView;

        // Last open view
        public static PAPIView lastView { get; set; } = null;

        public static PAPIView Start()
        {
            PAPIApplication.Start();
            ((WelcomeView)welcomeView).Open();
            return welcomeView;
        }

    }
}
