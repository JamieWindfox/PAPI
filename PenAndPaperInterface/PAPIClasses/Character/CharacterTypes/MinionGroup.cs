using PAPI.Logging;
using PAPI.Exception;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Motivations;
using PAPI.Character.Skill;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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
        /// _archetype: if null, archetype is 'Townpeople'
        /// _species: if null, species is 'Human'
        /// _soak: if null, soak is set automatically
        /// _health: if null, health is set automatically, depending on species and brawn
        /// _defense: if null, all defense is 0
        /// _characteristics; if null, characteristics are random
        /// _equipment: if null, nothing is equipped
        /// _inventory: if null, the inventory is empty
        /// _skillSet: if null, the character does not know any skilsl
        /// _abilities: if null, the character does not have any abilities
        /// _career: if null, the character doesn't have a career
        /// _relationshipToParty: must be a value between -100 and +100, otherwise it gets set to -100 if too low, or to +100 if too high
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
        /// <param name="_relationshipToParty"></param>
        /// <param name="_groupSize"></param>
        [JsonConstructor]
        public MinionGroup(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, int _relationshipToParty, uint _groupSize) :
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _relationshipToParty)
        {
            this._groupSize = _groupSize;
        }

    }
}
