using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.DataTypes
{
    public class Modification
    {
        // The value of the modification; A positive value adds to the value, a negative takes from it
        private int m_value;

        // The Time intervall when the modification wears off
        private GameTimeInterval m_wearoff;


        // ################################################# CTORS #################################################

        // A blank Modification has a value of 0 and has an INVALID wear off
        public Modification() : this(0, GameTimeInterval.NOT_VALID)
        { }

        // A modification with just a value given is permanent
        public Modification(int value) : this(value, GameTimeInterval.NOT_VALID)
        { }

        // A modification can be constructed with a value and a wearoff
        public Modification(int value, GameTimeInterval wearoff)
        {
            m_value = value;
            m_wearoff = wearoff;
            WfLogger.Log(this.GetType() + ".CTOR", LogLevel.DEBUG, "Constructed Modification (Value = " + m_value + ", Wearoff = " + m_wearoff);
        }

        // ################################################# GETTER #################################################
        public int GetValue() { return m_value; }
        public GameTimeInterval GetWearOff() { return m_wearoff; }


        // ################################################# SETTER #################################################

    }
}
