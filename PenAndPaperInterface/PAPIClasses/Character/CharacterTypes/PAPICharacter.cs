using System;
using System.Collections.Generic;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using System.Text.Json.Serialization;
using PAPI.Logging;

namespace PAPI.Character.CharacterTypes
{
    public abstract class PAPICharacter
    {
        /// <summary>
        /// Type or Archetype of the character, e.g. Vendor, Settler, Bum, Pirate, etc.
        /// </summary>
        public string _archetype { get; private set; }

        /// <summary>
        /// The species or race of the character, e.g. Human, Bear, Troll, Witch, etc.
        /// </summary>
        public Species _species { get; private set; }

        /// <summary>
        /// The value of each hit that gets absorbed by the skin without damagin the character
        /// </summary>
        public Value _soak { get; private set; }

        /// <summary>
        /// The value & Threshold of the characters Wounds; If the character gets injured, the value rises
        /// by the amount of wounds
        /// </summary>
        public ThresholdValue _health { get; private set; }

        /// <summary>
        /// The number of SETBACK dice anyone gets, who attacks this character
        /// </summary>
        public Defense _defense { get; private set; }

        /// <summary>
        /// A Set of all characteristics a character has: Brawn, Agility, Intellect, Cunning, Willpwoer and Presence
        /// </summary>
        public CharacteristicSet _characteristics { get; private set; }

        /// <summary>
        /// All Items that are equipped at the moment
        /// </summary>
        public Equipment _equipment { get; private set; }

        /// <summary>
        /// All Items that are not equipped but on the character at the moment, e.g. in their backpack
        /// </summary>
        public Inventory _inventory { get; private set; }

        /// <summary>
        /// A list of all learned skills with their ranks
        /// </summary>
        public List<PAPISkill> _skillSet { get; private set; }

        /// <summary>
        /// A list of all learned abilities
        /// </summary>
        public List<Ability> _abilities { get; private set; }

        /// <summary>
        /// The career of the nemesis
        /// </summary>
        public Career _career { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a PAPI Character
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
        [JsonConstructor]
        public PAPICharacter(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics, Equipment _equipment,
            Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career)
        {
            this._archetype = (_archetype == null || _archetype == "") ? "Townspeople" : _archetype;
            this._species = (_species == null) ? SpeciesHandler.GetSpecies("Human") : _species;
            this._soak = (_soak == null) ? new Value(0, null) : _soak;
            this._characteristics = (_characteristics == null) ? CharacteristicFactory.RandomCharacteristicSet(0) : _characteristics;
            this._health = (_health == null) ? 
                new ThresholdValue((SpeciesHandler.GetInitialHealthThreshold(this._species) + _characteristics.Get(CharacteristicEnum.BRAWN)._value), 0, null) : _health;
            this._defense = (_defense == null) ? new Defense(0, null, 0, null) : _defense;
            this._equipment = (_equipment == null) ? new Equipment(null, null, null, null) : _equipment;
            this._inventory = (_inventory == null) ? new Inventory(null, null) : _inventory;
            this._skillSet = (_skillSet == null) ? new List<PAPISkill>() : _skillSet;
            this._abilities = (_abilities == null) ? new List<Ability>() : _abilities;
            this._career = _career;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character (" + this._species._name + 
                " " + this._archetype + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets all member sof PAPICharacter invalid
        /// </summary>
        public void SetInvalid()
        {
            this._archetype = "INVALID_CHARACTER";
            this._species = null;
            this._soak = null;
            this._characteristics = null;
            this._health = null;
            this._defense = null;
            this._equipment = null;
            this._inventory = null;
            this._skillSet = null;
            this._abilities = null;
            this._career = null;
        }

    }
}
