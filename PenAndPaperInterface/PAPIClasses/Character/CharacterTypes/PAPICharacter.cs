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
        // Type or Archetype of the character, e.g. Vendor, Settler, Bum, Pirate, etc.
        private string m_type;

        // The species or race of the character, e.g. Human, Bear, Troll, Witch, etc.
        public Species species { get; private set; }

        // The value of each hit that gets absorbed by the skin without damagin the character
        private uint m_soak;

        // The modification of the soak value
        private Modification m_soakModification;

        // The current value of the characters Wounds; If the character gets injured, the value rises by the amount of wounds
        private uint m_currentWounds;

        // The maximum amount of wounds, a character can suffer, before they faint
        private uint m_woundThreshold;

        // The modification of the wound threshold
        private Modification m_woundThresholdModification;

        // The number of SETBACK dice anyone gets, who attacks this character with a melee weapon or in brawl
        private uint m_defenceMelee;

        // The mdification of melee defense
        private Modification m_defenceMeleeModification;

        // The number of SETBACK dice anyone gets, who attacks this character with a ranged weapon or throwing things at them
        private uint m_defenceRanged;

        // The mdification of ranged defense
        private Modification m_defenceRangedModification;

        // A Set of all characteristics a character has: Brawn, Agility, Intellect, Cunning, Willpwoer and Presence
        private CharacteristicSet m_characteristics;

        // All Items that are equipped at the moment
        private Equipment m_equipment;

        // All Items that are not equipped but on the character at the moment, e.g. in their backpack
        private Inventory m_inventory;

        // A list of all learned skills with their ranks
        private List<PAPISkill> m_skills;

        // A list of all abilities
        private List<Ability> m_abilities;


        

    }
}
