using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character
{
    public interface IUniqueCharacter
    {
        // Returns the name of the unique character
        string GetName();

        // Returns a set of the 4 motivations (strength, flaw, desire, fear) of the  unique character to give them depth
        MotivationSet GetMotivations();

        // Sets the motivations
        void SetMotivationSet(MotivationSet motivationsSet);

        //Sets a specific motivation
        void SetMotivation(MotivationTypeEnum type, Motivation motivation);

    }
}
