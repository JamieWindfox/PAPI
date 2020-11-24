using PAPI.Exception;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character
{
    public class NonPlayerCharacter : PAPICharacter
    {
        // Level of hostility or friendship towards the player party(negative = hostile, positive = frielndy, range = -100 to +100)
        private int m_relationshipToParty;

        // Returns the level of hostility or friendship towards the player party(negative = hostile, positive = frielndy, range = -100 to +100)
        public int GetRelationshipToParty() { return m_relationshipToParty; }

        // Set the Rleationshsip level toward the party to the given level (negative = hostile, positive = friendly, range = -100 to +100)
        public void SetRelationshipToParty(int newRelationshipLevel)
        {
            if (newRelationshipLevel >= -100 && newRelationshipLevel <= 100)
            {
                m_relationshipToParty = newRelationshipLevel;
                WfGLogger.Log(this.GetType() + ".SetRelationshipToParty(int)", LogLevel.DEBUG, "Set relationship level towars player party to: " + m_relationshipToParty);
            }
            else
            {
                string excMsg = "Couldn't set relationship level topward player party to " + newRelationshipLevel + ", must be a value from -100 to +100";
                WfGLogger.Log(this.GetType() + ".SetRelationshipToParty(int)", LogLevel.WARNING, excMsg);
                throw new OutOfRangeException(excMsg);
            }
        }
    }
}
