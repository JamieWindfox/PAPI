using PAPI.Character.Motivations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.CharacterTypes
{
    public class UniqueRival : Rival
    {
        /// <summary>
        /// The set of the 4 motiavtions (Strength, Flaw, Desire, Fear) each unique character has
        /// </summary>
        public MotivationSet _motivationSet { get; private set; }

        /// <summary>
        /// The name under which the players know the rival
        /// </summary>
        public string _name { get; private set; }

        

    }
}
