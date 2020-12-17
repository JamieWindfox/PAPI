using PAPI.Character.Motivations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.CharacterTypes
{
    public class PlayerCharacter : PAPICharacter
    {
        /// <summary>
        /// The set of the 4 motiavtions (Strength, Flaw, Desire, Fear) each player character has
        /// </summary>
        public MotivationSet _motivationSet { get; private set; }

        /// <summary>
        /// The name the player has given the character
        /// </summary>
        public string _name { get; private set; }

        /// <summary>
        /// The career of the character; it can't be changed after chosing it in character creation
        /// </summary>
        public Career _career { get; private set; }

        

    }
}
