using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using PAPI.Exception;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.CharacterTypes
{
    public class NonPlayerCharacter : PAPICharacter
    {
        /// <summary>
        /// Level of hostility or friendship towards the player party 
        /// negative = hostile, positive = friendly, range = -100 to +100
        /// </summary>
        public int _relationshipToParty { get; private set; }

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
        /// <param name="_relationshipToParty">must be a value between -100 and +100, otherwise it gets set to -100 if too low, or to +100 if too high</param>
        [JsonConstructor]
        public NonPlayerCharacter(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, CharacterAppearance _appearance, 
            int _relationshipToParty) : 
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _appearance)
        {
            _relationshipToParty = (_relationshipToParty < -100) ? -100 : _relationshipToParty;
            this._relationshipToParty = (_relationshipToParty > 100) ? 100 : _relationshipToParty;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new NPC (Relationship to Party = " + this._relationshipToParty + ")");
        }
    }
}
