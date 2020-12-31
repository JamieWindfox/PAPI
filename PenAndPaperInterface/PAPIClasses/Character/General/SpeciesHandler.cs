using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.DataTypes;
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
        /// <param name="speciesName">Name fo the required species, case-insensitive</param>
        /// <returns>The species with the given name</returns>
        public static Species GetSpecies(string speciesName)
        {
            foreach(Species species in _allSpecies)
            {
                if(species._nameKey.ToLower() == speciesName.ToLower())
                {
                    return species;
                }
            }
            return null;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The initial health threshold for the given species
        /// </summary>
        /// <param name="species">The name of the species for which the initial health threshold is needed</param>
        /// <returns>the initial health threshold of the given species</returns>
        public static uint GetInitialHealthThreshold(Species species)
        {
            switch (species._nameKey.ToLower())
            {
                case "human": return 10;

                default: return 10;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The initial strain threshold for the given species
        /// </summary>
        /// <param name="species">The name of the species for which the initial strain threshold is needed</param>
        /// <returns>the initial strain threshold of the given species</returns>
        public static uint GetInitialStrainThreshold(Species species)
        {
            switch (species._nameKey.ToLower())
            {
                case "human": return 10;

                default: return 10;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The average appearance of the given species
        /// </summary>
        /// <param name="species">The name of the species for which the aaverage appearance is requested</param>
        /// <returns>appearcane of an average individuum of the given species</returns>
        public static CharacterAppearance GetAverageAppearance(Species species)
        {
            switch(species._nameKey.ToLower())
            {
                case "human": return new CharacterAppearance();
                case "ghoul": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN,
                    ColorEnum.MEDIUM_FLESH, ColorEnum.NONE, "scarred, burnt", HairStyleEnum.BALD, ColorEnum.NONE, null, ColorEnum.GREY, "bloodshot", null, null);

                case "android": return new CharacterAppearance();

                case "mage": return new CharacterAppearance();

                case "catfolk": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, SkinColorTypeEnum.HARD_SOFT_DIFFERENCE, SkinTypeEnum.FUR,
                    ColorEnum.GREY, ColorEnum.LIGHT_GREY, "striped back, single color chest, soft and warm fur", HairStyleEnum.MEDIUM_BRAIDED, ColorEnum.DARK_GREY,
                    "traditionally braided with beads", ColorEnum.AMBER, "vertical pupils, widen to the side", new Dictionary<BodyPartEnum, AppearanceFeatureEnum>()
                    { { BodyPartEnum.TAIL, AppearanceFeatureEnum.NOTHING_SPECIAL} }, null);

                case "lizardfolk": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, SkinColorTypeEnum.HARD_SOFT_DIFFERENCE,
                    SkinTypeEnum.SCALES, ColorEnum.DARK_OLIVE, ColorEnum.OLIVE, "sturdy scales on the back and skin-like, softer scales on the chest and softer parts",
                    HairStyleEnum.BALD, ColorEnum.OLIVE, "horn-like scales instead of hair", ColorEnum.OLIVE, "vertical pupils, widen to the sides",
                    new Dictionary<BodyPartEnum, AppearanceFeatureEnum>(){{ BodyPartEnum.TAIL, AppearanceFeatureEnum.NOTHING_SPECIAL}}, null);

                default: return new CharacterAppearance();
            }
        }
    }
}
