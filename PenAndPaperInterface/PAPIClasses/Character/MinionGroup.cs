using PAPI.Logging;
using PAPI.Exception;


namespace PAPI.Character
{
    public class MinionGroup : NonPlayerCharacter
    {

        // Group size for minion group; 1 does not have any skills, recommended size = 2-5, possible size = 1-10
        private uint m_groupSize;


        // ################################################# CTOR #################################################


        // ################################################# GETTER #################################################

        public uint GetGroupSize() { return m_groupSize; }

        // ################################################# SETTER #################################################
        public void SetGroupSize(uint newSize)
        {
            if(newSize > 0 && newSize <= 10)
            {
                m_groupSize = newSize;
            }
            else
            {
                string excMsg = "Couldn't set the group size to " + newSize + " (The group size of a minion group must be between 1 and 10)";
                WfGLogger.Log(this.GetType() + ".SetGroupSize(uint)", LogLevel.ERROR, excMsg);
                throw new OutOfRangeException(excMsg);
            }
        }

    }
}
