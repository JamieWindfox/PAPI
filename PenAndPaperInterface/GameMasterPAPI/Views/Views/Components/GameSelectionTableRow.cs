using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views.Views.Components
{
    class GameSelectionTableRow
    {
        public Label _genreLabel { get; set; }
        public Label _dateOfCreationLabel { get; set; }
        public Label _dateOfLastSaveLabel { get; set; }
        public Button _loadButton { get; set; }
        public Button _deleteButton { get; set; }
        public bool _isVisible { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        public GameSelectionTableRow(Label genre, Label dateOfCreation, Label dateOfLastSave, Button loadButton, Button deleteButton)
        {
            _genreLabel = genre;
            _dateOfCreationLabel = dateOfCreation;
            _dateOfLastSaveLabel = dateOfLastSave;
            _loadButton = loadButton;
            _deleteButton = deleteButton;
            _isVisible = false;
            SetVisibility(false);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public void SetVisibility(bool isVisible)
        {
            if (_isVisible == isVisible) return;

            _genreLabel.Visible = isVisible;
            _dateOfCreationLabel.Visible = isVisible;
            _dateOfLastSaveLabel.Visible = isVisible;
            _loadButton.Visible = isVisible;
            _deleteButton.Visible = isVisible;
        }
    }
}
