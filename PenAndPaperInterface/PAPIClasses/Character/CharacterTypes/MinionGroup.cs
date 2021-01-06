using PAPI.Logging;
using PAPI.Exception;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Motivations;
using PAPI.Character.Skill;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using PAPI.Character.Appearance;
using PAPI.DataTypes;

namespace PAPI.Character.CharacterTypes
{
    public class MinionGroup : NonPlayerCharacter
    {

        /// <summary>
        /// Group size for minion group; 1 does not have any skills, 
        /// recommended size = 2-5, possible size = 1-10
        /// </summary>
        public uint _groupSize { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of a NonPlayerCharacter;
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
        /// <param name="_groupSize">the number of units in the minion group</param>
        [JsonConstructor]
        public MinionGroup(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, CharacterAppearance _appearance,
            GenderEnum _gender, List<GenderEnum> _genderPreferences, int _relationshipToParty, uint _groupSize) :
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _appearance, _gender, 
                _genderPreferences, _relationshipToParty)
        {
            this._groupSize = _groupSize;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Minion Group");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates 1 basic human minion as default
        /// </summary>
        public MinionGroup() : base()
        {
            _groupSize = 1;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Minion Group from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given MinionGroup
        /// </summary>
        /// <param name="other">if null, a default minion is created</param>
        public MinionGroup(MinionGroup other) : this()
        {
            if (other == null) return;

            _groupSize = other._groupSize;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Minion Group form another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
