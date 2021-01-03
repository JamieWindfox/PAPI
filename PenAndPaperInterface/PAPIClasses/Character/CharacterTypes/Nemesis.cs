using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Motivations;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.CharacterTypes
{
    public class Nemesis : UniqueRival
    {

        /// <summary>
        /// The strain and it's threshold
        /// </summary>
        public ThresholdValue _strain { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///  The JSON Constructor must contain all traits of a Nemesis;
        /// </summary>
        /// <param name="_archetype">if null, archetype is 'Townpeople'</param>
        /// <param name="_species">if null, species is 'Human'</param>
        /// <param name="_soak">if null, soak is set automatically</param>
        /// <param name="_health"> if null, health is set automatically, depending on species and brawn</param>
        /// <param name="_defense">if null, all defense is 0</param>
        /// <param name="_characteristics">if null, characteristics are random</param>
        /// <param name="_equipment">if null, nothing is equipped</param>
        /// <param name="_inventory">if null, the inventory is empty</param>
        /// <param name="_skillSet">if null, the character does not know any skills</param>
        /// <param name="_abilities">if null, the character does not have any abilities</param>
        /// <param name="_career">if null, the character doesn't have a career</param>
        /// <param name="_appearance">if null, the character/creature looks like an average specimen of its species</param>
        /// <param name="_gender">the characters gender</param>
        /// <param name="_genderPreferences">the characters sexcual/romabtic preferences, if null it is none</param>
        /// <param name="_relationshipToParty">must be a value between -100 and +100, otherwise it gets set to -100 if too low, or to +100 if too high</param>
        /// <param name="_criticalInjuries">If null or empty, the Rival is not suffering from any critical injuries</param>
        /// <param name="_name">if null or empty, the unique rival is invalid</param>
        /// <param name="_motivationSet">if null or empty, the motivations are set random</param>
        /// <param name="_strain">if null or 0, strain is set automatically, depending on the species</param>
        [JsonConstructor]
        public Nemesis(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, CharacterAppearance _appearance,
            GenderEnum _gender, List<GenderEnum> _genderPreferences, int _relationshipToParty, List<CriticalInjury> _criticalInjuries, string _name,
            MotivationSet _motivationSet, ThresholdValue _strain) :
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _appearance, _gender, 
                _genderPreferences, _relationshipToParty, _criticalInjuries, _name, _motivationSet)
        {
            this._strain = (_strain == null || _strain._threshold == 0) ? new ThresholdValue(SpeciesHandler.GetInitialStrain(this._species)) : _strain;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Nemesis " + this._name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Nemesis() : base()
        {
            _strain = new ThresholdValue();

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Nemesis from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Nemesis(Nemesis other) : this()
        {
            if (other == null) return;

            _strain = new ThresholdValue(other._strain);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Nemesis from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
