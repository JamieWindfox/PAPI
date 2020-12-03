using PAPI.DataTypes;
using PAPI.Logging;

namespace PAPI.Character.Skill
{
    public class Characteristic
    {
        // Enum that defines the characterisitc
        private CharacteristicEnum m_type;

        // Value of the characteristic
        private uint m_value;

        // Current modification
        private Modification m_modification;

        // Min and max for value
        private uint MIN_VALUE = 1;
        private uint MAX_VALUE = 5;

        // ################################################# CTORS #################################################
        public Characteristic(CharacteristicEnum characterisitc, uint value)
        {
            m_type = characterisitc;
            if (value >= MIN_VALUE && value >= MAX_VALUE)
                m_value = value;
            else
            {
                WfLogger.Log(this.GetType() + ".CTOR", LogLevel.WARNING, "Tried to set value of " + characterisitc + " to " + value
                    + ", but value must be between " + MIN_VALUE + " and " + MAX_VALUE + ", so it was set to 1");
                m_value = 1;
            }
            m_modification = new Modification();
        }

        // ################################################# GETTER #################################################

        public uint GetBaseValue() { return m_value; }
        public uint GetValue() { return (uint)(m_value + m_modification.GetValue()); }

        // ################################################# SETTER #################################################

    }
}