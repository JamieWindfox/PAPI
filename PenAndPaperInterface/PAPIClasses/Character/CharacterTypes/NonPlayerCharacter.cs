using PAPI.Exception;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.CharacterTypes
{
    public class NonPlayerCharacter : PAPICharacter
    {
        /// <summary>
        /// Level of hostility or friendship towards the player party 
        /// negative = hostile, positive = friendly, range = -100 to +100
        /// </summary>
        public int _relationshipToParty { get; private set; }

        
    }
}
