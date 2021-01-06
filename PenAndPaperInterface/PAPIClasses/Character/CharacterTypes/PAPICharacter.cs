using System.Collections.Generic;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using System.Text.Json.Serialization;
using PAPI.Logging;
using PAPI.Character.Appearance;

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
        /// The value of each hit that gets absorbed by the skin without damaging the character
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
        /// All Items that are not equipped but on the character at the moment, e.g. in their backpack/body (even teeth or fur for creatures
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

        /// <summary>
        /// The many features that make up the general appearance of a character/creature
        /// </summary>
        public CharacterAppearance _appearance { get; private set; }

        /// <summary>
        /// Gender and sexual/romantic orientation of the character
        /// </summary>
        public GenderEnum _gender { get; private set; }
        public List<GenderEnum> _genderPreferences { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of a PAPI Character
        /// </summary>
        /// <param name="_archetype">if null, archetype is 'Townpeople'</param>
        /// <param name="_species">if null, species is 'Human'</param>
        /// <param name="_soak">if null, soak is set automatically</param>
        /// <param name="_health"> if null, health is set automatically, depending on species and brawn</param>
        /// <param name="_defense">if null, all defense is 0</param>
        /// <param name="_characteristics">if null, all characteristics are 1</param>
        /// <param name="_equipment">if null, nothing is equipped</param>
        /// <param name="_inventory">if null, the inventory is empty</param>
        /// <param name="_skillSet">if null, the character does not know any skills</param>
        /// <param name="_abilities">if null, the character does not have any abilities</param>
        /// <param name="_career">if null, the character doesn't have a career</param>
        /// <param name="_appearance">if null, the character/creature looks like an average specimen of its species</param>
        /// <param name="_gender">the characters gender</param>
        /// <param name="_genderPreferences">the characters sexcual/romabtic preferences, if null it is none</param>
        [JsonConstructor]
        public PAPICharacter(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics, 
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, CharacterAppearance _appearance, 
            GenderEnum _gender, List<GenderEnum> _genderPreferences)
        {
            this._archetype = (_archetype == null || _archetype == "") ? "Townspeople" : _archetype;
            this._species = (_species == null) ? SpeciesHandler.GetSpecies("Human") : _species;
            this._soak = (_soak == null) ? new Value(0, null) : _soak;
            this._characteristics = (_characteristics == null) ? new CharacteristicSet() : _characteristics;
            this._health = (_health == null) ? 
                new ThresholdValue(SpeciesHandler.GetInitialHealth(this._species)) : _health;
            this._defense = (_defense == null) ? new Defense(0, null, 0, null) : _defense;
            this._equipment = (_equipment == null) ? new Equipment(null, null, null, null) : _equipment;
            this._inventory = (_inventory == null) ? new Inventory(null, null) : _inventory;
            this._skillSet = (_skillSet == null) ? new List<PAPISkill>() : _skillSet;
            this._abilities = (_abilities == null) ? new List<Ability>() : _abilities;
            this._career = _career;
            this._appearance = (_appearance == null) ? new CharacterAppearance(SpeciesHandler.GetAverageAppearance(this._species)) : _appearance;
            this._gender = _gender;
            this._genderPreferences = (_genderPreferences == null || _genderPreferences.Count == 0) ? new List<GenderEnum>() { GenderEnum.NONE } : _genderPreferences;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character (" + this._species._nameKey + 
                " " + this._archetype + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// Default CTOR creates an average bald, other gendered human without any skills and a all characteristics 1
        /// </summary>
        public PAPICharacter() : this(null, null, null, null, null, null, null, null, null, null, null, null, GenderEnum.OTHER, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Copy CTOR
        /// </summary>
        /// <param name="other"></param>
        public PAPICharacter(PAPICharacter other) : this()
        {
            if (other == null) return;

            _archetype = other._archetype;
            _species = new Species(other._species);
            _soak = new Value(other._soak);
            _health = new ThresholdValue(other._health);
            _defense = new Defense(other._defense);
            _characteristics = new CharacteristicSet(other._characteristics);
            _equipment = new Equipment(other._equipment);
            _inventory = new Inventory(other._inventory);
            _skillSet = new List<PAPISkill>(other._skillSet);
            _abilities = new List<Ability>(other._abilities);
            _career = new Career(other._career);
            _appearance = new CharacterAppearance(other._appearance);
            _gender = other._gender;
            _genderPreferences = new List<GenderEnum>(other._genderPreferences);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
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
