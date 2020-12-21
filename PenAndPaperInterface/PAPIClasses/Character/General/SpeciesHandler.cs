using PAPI.Character.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.General
{
    public class SpeciesHandler
    {
        public static List<Species> _allSpecies { get; private set; } = new List<Species>()
        {
            new Species("Human", null)
        };

        // --------------------------------------------------------------------------------------------------------------------------------

        public static Species GetSpecies(string speciesName)
        {
            foreach(Species species in _allSpecies)
            {
                if(species._name == speciesName)
                {
                    return species;
                }
            }
            return null;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static uint GetInitialHealthThreshold(Species species)
        {
            switch(species._name)
            {
                case "Human": return 10;

                default: return 10;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static uint GetInitialStrainThreshold(Species species)
        {
            switch (species._name)
            {
                case "Human": return 10;

                default: return 10;
            }
        }
    }
}
