using System.Resources;
using System.Windows.Forms;

namespace PAPIClient
{
    public interface ITranslatableView
    {
        void SetTextToActiveLanguage();
        string Translate(ResXResourceSet resSet, Control control);

        string GetTranslationFile();
    }
}