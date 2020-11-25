using PAPI.Logging;
using PAPI.Character.Skill;
using PAPI.Exception;

namespace PAPI.Character
{
    public class CharacteristicSet
    {
        // Characteristic BRAWN for strength, toughness, indicator for wound threshold
        private Characteristic m_brawn;

        // Characteristic AGILITY for dexterity, hand-eye coordination and body control
        private Characteristic m_agility;

        // Characteristic INTELLECT for intelligence, education and mental acuity
        private Characteristic m_intellect;

        // Characteristic CUNNING for crafting, cleverness, creativity and how devious someone is
        private Characteristic m_cunning;

        // Characteristic WILLPOWER for discipline, self-control, mental fortitude and faith
        private Characteristic m_willpower;

        // Characteristic PRESENCE for charisma, confidence and force of personality
        private Characteristic m_presence;


        // ################################################# CTORS #################################################
        public CharacteristicSet(uint br, uint ag, uint inte, uint cu, uint wi, uint pr)
        {
            m_brawn = new Characteristic(CharacteristicEnum.BRAWN, br);
            m_agility = new Characteristic(CharacteristicEnum.AGILITY, ag);
            m_intellect = new Characteristic(CharacteristicEnum.INTELLECT, inte);
            m_cunning = new Characteristic(CharacteristicEnum.CUNNING, cu);
            m_willpower = new Characteristic(CharacteristicEnum.WILLPOWER, wi);
            m_presence = new Characteristic(CharacteristicEnum.PRESENCE, pr);

            WfGLogger.Log(this.GetType() + ".CTOR", LogLevel.INFO, "Constructed CharacterisitcSet (" +
                "BR = " + m_brawn.GetBaseValue() +
                "AG = " + m_agility.GetBaseValue() +
                "IN = " + m_intellect.GetBaseValue() +
                "CU = " + m_cunning.GetBaseValue() +
                "WI = " + m_willpower.GetBaseValue() +
                "PR = " + m_presence.GetBaseValue() + ")");
        }

        // A blank characteristic Set results in one point per characteristic as an absolute minimum
        public CharacteristicSet():this(1, 1, 1, 1, 1, 1)
        { }

        // ################################################# GETTER #################################################
        public Characteristic Get(CharacteristicEnum characteristic)
        {
            switch (characteristic)
            {
                case CharacteristicEnum.BRAWN: return m_brawn;
                case CharacteristicEnum.AGILITY: return m_agility;
                case CharacteristicEnum.INTELLECT: return m_intellect;
                case CharacteristicEnum.CUNNING: return m_cunning;
                case CharacteristicEnum.WILLPOWER: return m_willpower;
                case CharacteristicEnum.PRESENCE: return m_presence;
                default:
                    string excMsg = "The Characteristic Enum value " + characteristic.ToString() + " doesn't exist.";
                    WfGLogger.Log(this.GetType() + " Get(" + characteristic + ")", LogLevel.FATAL, excMsg);
                    throw new EnumNotFoundException(excMsg);
            }
        }


        // ################################################# SETTER #################################################

    }
}