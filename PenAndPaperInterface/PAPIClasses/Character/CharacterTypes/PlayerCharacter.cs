using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Motivations;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using PAPI.Logging;
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

        /// <summary>
        /// The player characters strain
        /// </summary>
        public ThresholdValue _strain { get; private set; }

        /// <summary>
        /// A list of the career skills, which are cheaper to train and whose first rank is for free
        /// </summary>
        public List<SkillEnum> _careerSkills { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// /// The JSON Constructor must contain all possible traits of a PAPI Character
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
        /// <param name="_name">if null, the character is invlaid</param>
        /// <param name="_motivationSet">if null, the character gets random motivations</param>   
        /// <param name="_criticalInjuries">if null, there a re no critical injuries (yet)</param>
        /// <param name="_strain">the strain of the player character</param>
        /// <param name="_careerSkills">a list of the career skills, if null nothing has been chosen yet</param>
        [JsonConstructor]
        public PlayerCharacter(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, CharacterAppearance _appearance,
            GenderEnum _gender, List<GenderEnum> _genderPreferences, string _name, MotivationSet _motivationSet, List<CriticalInjury> _criticalInjuries, 
            ThresholdValue _strain, List<SkillEnum> _careerSkills) : 
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _appearance, _gender, 
                _genderPreferences)
        {
            if(_name == null || _name == "")
            {
                SetInvalid();
                return;
            }
            this._name = _name;
            this._motivationSet = (_motivationSet == null) ? new MotivationSet() : _motivationSet;
            this._criticalInjuries = (_criticalInjuries == null) ? new List<CriticalInjury>() : _criticalInjuries;
            this._strain = (_strain == null) ? SpeciesHandler.GetInitialStrain(this._species) : _strain;
            this._careerSkills = (_careerSkills == null) ? new List<SkillEnum>() : _careerSkills;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new PlayerCharacter " + this._name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default CTOR creates an invalid average bald, other gendered human without any skills and a all characteristics 1
        /// </summary>
        public PlayerCharacter() : base()
        {
            _name = "INVALID_PLAYER_CHARACTER";
            _motivationSet = new MotivationSet();
            _criticalInjuries = new List<CriticalInjury>();
            _strain = new ThresholdValue();
            _careerSkills = new List<SkillEnum>();

            WfLogger.Log(this, LogLevel.DETAILED, "Created new PlayerCharacter from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public PlayerCharacter(PlayerCharacter other) : this()
        {
            if (other == null) return;

            _name = other._name;
            _motivationSet = new MotivationSet(other._motivationSet);
            _criticalInjuries = new List<CriticalInjury>(other._criticalInjuries);
            _strain = new ThresholdValue(other._strain);
            _careerSkills = new List<SkillEnum>(other._careerSkills);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new PlayerCharacter from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------


    }
}
