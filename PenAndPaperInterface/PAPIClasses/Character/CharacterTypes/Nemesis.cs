using PAPI.Character.Motivations;
using System;


namespace PAPI.Character.CharacterTypes
{
    public class Nemesis : Rival
    {
        /// <summary>
        /// The set of the 4 motiavtions (Strength, Flaw, Desire, Fear) each nemesis has
        /// </summary>
        public MotivationSet _motivationSet { get; private set; }

        /// <summary>
        /// The name under which the players know the nemesis
        /// </summary>
        public string _name { get; private set; }

        

    }
}
