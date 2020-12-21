using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Motivations;
using PAPI.Character.Skill;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.CharacterTypes
{
    public class PlayerCharacter : PAPICharacter
    {
       /// <summary>
        /// The name the player has given the character
        /// </summary>
        public string _name { get; private set; }

        /// <summary>
        /// The set of the 4 motiavtions (Strength, Flaw, Desire, Fear) each player character has
        /// </summary>
        public MotivationSet _motivationSet { get; private set; }

        /// <summary>
        /// A list of all active critical injuries
        /// </summary>
        public List<CriticalInjury> _criticalInjuries { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// /// The JSON Constructor must contain all possible traits of a PAPI Character
        /// _archetype: if null, archetype is 'Player Character'
        /// _species: if null, species is 'Human'
        /// _soak: if null, soak is set automatically
        /// _health: if null, health is set automatically, depending on species and brawn
        /// _defense: if null, all defense is 0
        /// _characteristics; if null, characteristics are random
        /// _equipment: if null, nothing is equipped
        /// _inventory: if null, the inventory is empty
        /// _skillSet: if null, the character does not know any skills
        /// _abilities: if null, the character does not have any abilities
        /// _career: if null, the character doesn't have a career
        /// _name: if null, the character is invlaid
        /// _motiavationSet: if null, the character gets random motivations
        /// </summary>
        /// <param name="_archetype"></param>
        /// <param name="_species"></param>
        /// <param name="_soak"></param>
        /// <param name="_health"></param>
        /// <param name="_defense"></param>
        /// <param name="_characteristics"></param>
        /// <param name="_equipment"></param>
        /// <param name="_inventory"></param>
        /// <param name="_skillSet"></param>
        /// <param name="_abilities"></param>
        /// <param name="_career"></param>
        /// <param name="_name"></param>
        /// <param name="_motivationSet"></param>        
        [JsonConstructor]
        public PlayerCharacter(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, 
            CharacteristicSet _characteristics, Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, 
            List<Ability> _abilities, Career _career, string _name, MotivationSet _motivationSet) : 
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career)
        {
            if(_name == null || _name == "")
            {
                SetInvalid();
                return;
            }
            this._name = _name;
            this._motivationSet = (_motivationSet == null) ? new MotivationSet(null) : _motivationSet;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets all members of the playerCharacter invalid
        /// </summary>
        private new void SetInvalid()
        {
            base.SetInvalid();
            _name = "INVALID_PLAYER_CHARACTER";
            _motivationSet = null;
        }
    }
}
