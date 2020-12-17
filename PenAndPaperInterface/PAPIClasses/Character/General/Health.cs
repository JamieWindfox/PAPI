using PAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.General
{
    public class Health
    {
        public uint _woundThreshold { get; private set; }
        public uint _woundsSuffered { get; private set; }
        public Modification _modification { get; private set; }
    }
}
