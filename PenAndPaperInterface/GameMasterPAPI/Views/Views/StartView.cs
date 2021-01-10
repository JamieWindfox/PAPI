using PAPI.Logging;
using PAPI.Settings.Game;
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

namespace PAPIClient.Views
{
    public partial class StartView : PAPIView
    {

        private Button _lastClicked = null;
        private bool _lastClickTranslated = false;

        /// <summary>
        /// The start view shows all functions a player has:
        /// * Games
        /// * Characters
        /// * Vehicles
        /// * Buildings
        /// * Items
        /// </summary>
        public StartView() : base()
        {
            InitializeComponent();

            _buttons.Add(return_button);
            _buttons.Add(game_selection_button);
            _buttons.Add(character_selection_button);
            _buttons.Add(item_selection_button);
            _buttons.Add(vehicle_selection_button);
            _buttons.Add(building_selection_button);
            _buttons.Add(open_creator_button);

            SetButtonDesign();
            open_creator_button.Visible = false;
        }
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Set all text in this view to the language which was set in the settings
        /// </summary>
        public override void SetTextToActiveLanguage()
        {
            if (_shownLanguage == PAPIApplication.GetLanguage() && _lastClickTranslated)
            {
                return;
            }
            _shownLanguage = PAPIApplication.GetLanguage();

            using (ResXResourceSet resSet = new ResXResourceSet(GetTranslationFile()))
            {
                Translate(resSet, return_button);
                Translate(resSet, selection_label);
                Translate(resSet, description_label);
                Translate(resSet, game_selection_button);
                Translate(resSet, character_selection_button);
                Translate(resSet, item_selection_button);
                Translate(resSet, vehicle_selection_button);
                Translate(resSet, building_selection_button);
                Translate(resSet, open_creator_button);
                if (selection_description_label.Text == "selection_description") selection_description_label.Text = "";

                if (_lastClicked != null)
                {
                    selection_description_label.Text = TranslatedString(resSet, _lastClicked.Name + "_DESCRIPTION");
                    _lastClickTranslated = true;
                }
            }

            WfLogger.Log(this, LogLevel.DEBUG, "All text of start view set to " + PAPIApplication.GetLanguage());
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void game_selection_button_Click(object sender, EventArgs e)
        {
            _lastClicked = game_selection_button;
            _lastClickTranslated = false;
            WfLogger.Log(this, LogLevel.DEBUG, "The 'Games' Button was clicked");
            SetTextToActiveLanguage();
            open_creator_button.Visible = true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void character_selection_button_Click(object sender, EventArgs e)
        {
            _lastClicked = character_selection_button;
            _lastClickTranslated = false;
            WfLogger.Log(this, LogLevel.DEBUG, "The 'Characters' Button was clicked");
            SetTextToActiveLanguage();
            // uncomment next line, when creator is implemented
            //open_creator_button.Visible = true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void item_selection_button_Click(object sender, EventArgs e)
        {
            _lastClicked = item_selection_button;
            _lastClickTranslated = false;
            WfLogger.Log(this, LogLevel.DEBUG, "The 'Items' Button was clicked");
            SetTextToActiveLanguage();
            // uncomment next line, when creator is implemented
            //open_creator_button.Visible = true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void vehicle_selection_button_Click(object sender, EventArgs e)
        {
            _lastClicked = vehicle_selection_button;
            _lastClickTranslated = false;
            WfLogger.Log(this, LogLevel.DEBUG, "The 'Vehicles' Button was clicked");
            SetTextToActiveLanguage();
            // uncomment next line, when creator is implemented
            //open_creator_button.Visible = true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void building_selection_button_Click(object sender, EventArgs e)
        {
            _lastClicked = building_selection_button;
            _lastClickTranslated = false;
            WfLogger.Log(this, LogLevel.DEBUG, "The 'Buildings' Button was clicked");
            SetTextToActiveLanguage();
            // uncomment next line, when creator is implemented
            //open_creator_button.Visible = true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void open_creator_button_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "The 'Open Creator' Button was clicked");
            
            if(_lastClicked == game_selection_button)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Open Game Selection View not yet implemented.");
                ViewController.gameSelectionView.Open(this);
            }
            else if (_lastClicked == character_selection_button)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Open Character Selection View not yet implemented.");
                //ViewController.characterSelectionView.Open();
            }
            else if (_lastClicked == item_selection_button)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Open Item Selection View not yet implemented.");
                //ViewController.itemSelectionView.Open();
            }
            else if (_lastClicked == vehicle_selection_button)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Open Vehicle Selection View not yet implemented.");
                //ViewController.vehicleSelectionView.Open();
            }
            else if (_lastClicked == building_selection_button)
            {
                WfLogger.Log(this, LogLevel.WARNING, "Open Building Selection View not yet implemented.");
                //ViewController.buildingSelectionView.Open();
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private void return_button_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Return button was clicked, and view changes to " + ViewController.welcomeView.GetType());
            ViewController.welcomeView.Open(this);
            open_creator_button.Visible = false;
        }
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
