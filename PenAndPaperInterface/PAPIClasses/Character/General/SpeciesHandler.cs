using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.DataTypes;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.General
{
    public class SpeciesHandler
    {
        public static List<Species> _allSpecies { get; private set; } = new List<Species>()
        {
            new Species("Species_HUMAN", null),
            new Species("Species_GHOUL", new List<Settings.GenreEnum>(){ GenreEnum.NUCLEAR_FALLOUT}),
            new Species("Species_ANDROID", new List<GenreEnum>(){ GenreEnum.NUCLEAR_FALLOUT, GenreEnum.SPACE_OPERA}),
            new Species("Species_MAGE", new List<GenreEnum>(){ GenreEnum.MAGICAL_WORLD, GenreEnum.MEDIEVAL_FANTASY}),
            new Species("Species_CATFOLK", new List<GenreEnum>(){ GenreEnum.MEDIEVAL_FANTASY, GenreEnum.SPACE_OPERA}),
            new Species("Species_LIZARDFOLK", new List<GenreEnum>(){ GenreEnum.MEDIEVAL_FANTASY, GenreEnum.SPACE_OPERA}),
            new Species("Species_ROBOT", new List<GenreEnum>(){GenreEnum.NUCLEAR_FALLOUT, GenreEnum.SPACE_OPERA}),
            new Species("Species_SUPER_MUTANT", new List<GenreEnum>(){GenreEnum.NUCLEAR_FALLOUT})
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
        public static ThresholdValue GetInitialHealth(Species species)
        {
            switch (species._nameKey.ToLower())
            {
                case "species_human": return new ThresholdValue(10, 0, null);

                case "species_ghoul": return new ThresholdValue(11, 0, null);

                case "species_android": return new ThresholdValue(11, 0, null);

                case "species_mage": return new ThresholdValue(10, 0, null);

                case "species_catfolk": return new ThresholdValue(10, 0, null);

                case "species_lizardfolk": return new ThresholdValue(10, 0, null);

                case "species_robot": return new ThresholdValue(10, 0, null);

                case "species_super_mutant": return new ThresholdValue(13, 0, null);

                default: return new ThresholdValue(10, 0, null);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The initial strain threshold for the given species
        /// </summary>
        /// <param name="species">The name of the species for which the initial strain threshold is needed</param>
        /// <returns>the initial strain threshold of the given species</returns>
        public static ThresholdValue GetInitialStrain(Species species)
        {
            switch (species._nameKey.ToLower())
            {
                case "species_human": return new ThresholdValue(10, 0, null);

                case "species_ghoul": return new ThresholdValue(10, 0, null);

                case "species_android": return new ThresholdValue(10, 0, null);

                case "species_mage": return new ThresholdValue(10, 0, null);

                case "species_catfolk": return new ThresholdValue(10, 0, null);

                case "species_lizardfolk": return new ThresholdValue(9, 0, null);

                case "species_robot": return new ThresholdValue(10, 0, null);

                case "species_super_mutant": return new ThresholdValue(9, 0, null);

                default: return new ThresholdValue(10, 0, null);
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
                case "species_human": return new CharacterAppearance();
                case "species_ghoul": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.MEDIUM_FLESH, ColorEnum.NONE, "scarred, burnt"), // skin
                    new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.NONE, null), // hair
                    ColorEnum.GREY, "bloodshot", // eyes
                    50, null, null); // age and general appearance

                case "species_android": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.ARTIFICIAL_SKIN, ColorEnum.MEDIUM_FLESH, ColorEnum.NONE, null), // skin
                    new Hair(), // hair
                    ColorEnum.GREY, null, // eyes
                    30, null, null);

                case "species_mage": return new CharacterAppearance();

                case "species_catfolk": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.HARD_SOFT_DIFFERENCE, SkinTypeEnum.FUR, ColorEnum.GREY, ColorEnum.LIGHT_GREY, 
                        "striped in the back, single colored chest, soft and warm fur"), // skin
                    new Hair(HairStyleEnum.BRAIDED, HairLengthEnum.MEDIUM, ColorEnum.DARK_GREY, "traditionally braided with beads"), // hair
                    ColorEnum.AMBER, "vertical pupils, widen to the side", // eyes
                    25, new Dictionary<BodyPartEnum, AppearanceFeatureEnum>() { { BodyPartEnum.TAIL, AppearanceFeatureEnum.NOTHING_SPECIAL} }, null); // age an general appearance

                case "species_lizardfolk": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.HARD_SOFT_DIFFERENCE, SkinTypeEnum.SCALES, ColorEnum.DARK_OLIVE, ColorEnum.OLIVE, 
                        "sturdy scales on the back and skin-like, softer scales on the chest and softer parts"), // skin 
                    new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.OLIVE, "horn-like scales instead of hair"), // hair
                    ColorEnum.OLIVE, "vertical pupils, widen to the sides", // eyes
                    25, new Dictionary<BodyPartEnum, AppearanceFeatureEnum>(){{ BodyPartEnum.TAIL, AppearanceFeatureEnum.NOTHING_SPECIAL}}, null); // age and general appearance

                case "species_robot": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.METAL, ColorEnum.STEEL_GREY, ColorEnum.NONE, null), // skin
                    new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.NONE, null), // hair
                    ColorEnum.BLACK, null, // eyes
                    50, null, "robotic");

                case "species_super_mutant": return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, "very big and bulky", // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.GREY, ColorEnum.NONE, null),
                    new Hair(),
                    ColorEnum.GREEN, null,
                    50, null, null);

                default: return new CharacterAppearance();
            }
        }
    }
}
