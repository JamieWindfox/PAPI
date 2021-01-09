

namespace PAPIClient.Views
{
    public interface IPAPIView
    {
        // Translates all text on the view to the language which was set in options, or - if none is set - to English
        void SetTextToActiveLanguage();

        // Initialiizes the views' and it's components' formats, this method must include InitializeComponents()
        void Init();


    }
}
