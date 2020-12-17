using PAPI.Logging;
using PAPI.Exception;


namespace PAPI.Character.CharacterTypes
{
    public class MinionGroup : NonPlayerCharacter
    {

        /// <summary>
        /// Group size for minion group; 1 does not have any skills, 
        /// recommended size = 2-5, possible size = 1-10
        /// </summary>
        public uint _groupSize { get; private set; }


    }
}
