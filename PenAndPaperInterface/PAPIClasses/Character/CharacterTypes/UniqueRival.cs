﻿using PAPI.Character.Characteristics;
using PAPI.Character.General;
using PAPI.Character.Motivations;
using PAPI.Character.Skill;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.CharacterTypes
{
    public class UniqueRival : Rival
    {
        /// <summary>
        /// The set of the 4 motiavtions (Strength, Flaw, Desire, Fear) each unique character has
        /// </summary>
        public MotivationSet _motivationSet { get; private set; }

        /// <summary>
        /// The name under which the players know the rival
        /// </summary>
        public string _name { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// /// The JSON Constructor must contain all traits of a Rival;
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
        /// _criticalInjruies: If null or empty, the Rival is not suffering from any critical injuries
        /// _motivationSet: if null or empty, the motivations are set random
        /// _name: if null or empty, the unique rival is invalid
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
        /// <param name="_criticalInjuries"></param>
        /// <param name="_name"></param>
        /// <param name="_motivationSet"></param>
        [JsonConstructor]
        public UniqueRival(string _archetype, Species _species, Value _soak, ThresholdValue _health, Defense _defense, CharacteristicSet _characteristics,
            Equipment _equipment, Inventory _inventory, List<PAPISkill> _skillSet, List<Ability> _abilities, Career _career, int _relationshipToParty,
            List<CriticalInjury> _criticalInjuries, string _name, MotivationSet _motivationSet) :
            base(_archetype, _species, _soak, _health, _defense, _characteristics, _equipment, _inventory, _skillSet, _abilities, _career, _relationshipToParty, _criticalInjuries)
        {
            if(_name == null || _name == "")
            {
                SetInvalid();
                this._name = "INVALID_UNIQUE_RIVAL";
                return;
            }

            this._name = _name;
            this._motivationSet = (_motivationSet == null) ? new MotivationSet(null) : _motivationSet;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Unique Rival: " + this._name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------



    }
}
