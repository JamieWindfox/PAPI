using System.Resources;
using System.Windows.Forms;

namespace GameMasterPAPI
{
    public interface ITranslatableView
    {
        void SetTextToActiveLanguage();
        void Translate(ResXResourceSet resSet, Control control);

        string GetResourceFile();
    }
}