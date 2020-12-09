using System.Collections.Generic;
using System.Windows.Forms;

namespace GameMasterPAPI
{
    public interface ITranslatableView
    {
        void SetTextToActiveLanguage();
        void Translate(ref List<Control> controls, bool translateSameLanguage);
    }
}