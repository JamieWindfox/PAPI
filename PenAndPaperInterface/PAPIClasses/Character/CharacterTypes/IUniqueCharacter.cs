using PAPI.Character.Motivations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.CharacterTypes
{
    public interface IUniqueCharacter
    {


        // Sets the motivations
        void SetMotivationSet(MotivationSet motivationsSet);

        //Sets a specific motivation
        void SetMotivation(Motivation motivation);

    }
}
