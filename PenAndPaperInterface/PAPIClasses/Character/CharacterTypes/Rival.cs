using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.CharacterTypes
{
    public class Rival : NonPlayerCharacter
    {
        /// <summary>
        /// A list of all active critical injuries
        /// </summary>
        public List<CriticalInjury> _criticalInjuries { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of a Rival
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
        /// <param name="_criticalInjuries">If null or empty, the Rival is not suffering from any critical injuries</param>
        [JsonConstructor]
        public Rival(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, CharacterAppearance _appearance, 
            int _relationshipToParty, List<CriticalInjury> _criticalInjuries) :
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _appearance, _relationshipToParty)
        {
            this._criticalInjuries = (_criticalInjuries == null) ? new List<CriticalInjury>() : _criticalInjuries;
        }

        // --------------------------------------------------------------------------------------------------------------------------------


    }
}
