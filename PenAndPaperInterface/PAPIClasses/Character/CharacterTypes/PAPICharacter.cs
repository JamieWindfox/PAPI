using System;
using System.Collections.Generic;
using PAPI.Character.Skill;
using PAPI.DataTypes;
using PAPI.Character.Characteristics;
using PAPI.Character.General;

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
        public Soak _soak { get; private set; }

        /// <summary>
        /// The value & Threshold of the characters Wounds; If the character gets injured, the value rises
        /// by the amount of wounds
        /// </summary>
        public Health _health { get; private set; }

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


    }
}
