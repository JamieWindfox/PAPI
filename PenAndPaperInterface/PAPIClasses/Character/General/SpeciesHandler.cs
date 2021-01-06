using PAPI.Character.Appearance;
using PAPI.Character.Characteristics;
using PAPI.DataTypes;
using PAPI.Settings;
using PAPI.Settings.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.General
{
    public class SpeciesHandler
    {
        /// <summary>
        /// A list of all available species
        /// </summary>
        public static List<Species> _allSpecies { get; private set; } = new List<Species>()
        {
            new Species(SpeciesEnum.HUMAN, null, null),
            new Species(SpeciesEnum.GHOUL, null, new List<Settings.GenreEnum>(){ GenreEnum.NUCLEAR_FALLOUT}),
            new Species(SpeciesEnum.ANDROID, null, new List<GenreEnum>(){ GenreEnum.NUCLEAR_FALLOUT, GenreEnum.SPACE_OPERA}),
            new Species(SpeciesEnum.MAGE, null, new List<GenreEnum>(){ GenreEnum.MAGICAL_WORLD, GenreEnum.MEDIEVAL_FANTASY}),
            new Species(SpeciesEnum.CATFOLK, null, new List<GenreEnum>(){ GenreEnum.MEDIEVAL_FANTASY, GenreEnum.SPACE_OPERA}),
            new Species(SpeciesEnum.LIZARDFOLK, null, new List<GenreEnum>(){ GenreEnum.MEDIEVAL_FANTASY, GenreEnum.SPACE_OPERA}),
            new Species(SpeciesEnum.ROBOT, null, new List<GenreEnum>(){GenreEnum.NUCLEAR_FALLOUT, GenreEnum.SPACE_OPERA}),
            new Species(SpeciesEnum.SUPER_MUTANT, null, new List<GenreEnum>(){GenreEnum.NUCLEAR_FALLOUT})
        };

        // --------------------------------------------------------------------------------------------------------------------------------
        /// <param name="speciesName">Enum of the required species, if it is available for the current genre, if there are more of the same enum, the first one is returned</param>
        /// <returns>The species with the given name</returns>
        public static Species GetSpecies(SpeciesEnum speciesEnum)
        {
            foreach(Species species in _allSpecies)
            {
                if(species._enum == speciesEnum && species.AvailableForGenre(PAPIApplication._runningGame._genre))
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
        public static ThresholdValue GetInitialHealth(SpeciesEnum species)
        {
            switch (species)
            {
                case SpeciesEnum.HUMAN: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.GHOUL: return new ThresholdValue(11, 0, null);

                case SpeciesEnum.ANDROID: return new ThresholdValue(11, 0, null);

                case SpeciesEnum.MAGE: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.CATFOLK: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.LIZARDFOLK: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.ROBOT: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.SUPER_MUTANT: return new ThresholdValue(13, 0, null);

                default: return new ThresholdValue(10, 0, null);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The initial strain threshold for the given species
        /// </summary>
        /// <param name="species">The name of the species for which the initial strain threshold is needed</param>
        /// <returns>the initial strain threshold of the given species</returns>
        public static ThresholdValue GetInitialStrain(SpeciesEnum species)
        {
            switch (species)
            {
                case SpeciesEnum.HUMAN: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.GHOUL: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.ANDROID: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.MAGE: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.CATFOLK: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.LIZARDFOLK: return new ThresholdValue(9, 0, null);

                case SpeciesEnum.ROBOT: return new ThresholdValue(10, 0, null);

                case SpeciesEnum.SUPER_MUTANT: return new ThresholdValue(9, 0, null);

                default: return new ThresholdValue(10, 0, null);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The average appearance of the given species
        /// </summary>
        /// <param name="species">The name of the species for which the aaverage appearance is requested</param>
        /// <returns>appearcane of an average individuum of the given species</returns>
        public static CharacterAppearance GetAverageAppearance(SpeciesEnum species)
        {
            switch(species)
            {
                case SpeciesEnum.HUMAN: return new CharacterAppearance();
                case SpeciesEnum.GHOUL: return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.MEDIUM_FLESH, ColorEnum.NONE, "scarred, burnt"), // skin
                    new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.NONE, null), // hair
                    ColorEnum.GREY, "bloodshot", // eyes
                    50, null, null); // age and general appearance

                case SpeciesEnum.ANDROID: return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.ARTIFICIAL_SKIN, ColorEnum.MEDIUM_FLESH, ColorEnum.NONE, null), // skin
                    new Hair(), // hair
                    ColorEnum.GREY, null, // eyes
                    30, null, null);

                case SpeciesEnum.MAGE: return new CharacterAppearance();

                case SpeciesEnum.CATFOLK: return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.HARD_SOFT_DIFFERENCE, SkinTypeEnum.FUR, ColorEnum.GREY, ColorEnum.LIGHT_GREY, 
                        "striped in the back, single colored chest, soft and warm fur"), // skin
                    new Hair(HairStyleEnum.BRAIDED, HairLengthEnum.MEDIUM, ColorEnum.DARK_GREY, "traditionally braided with beads"), // hair
                    ColorEnum.AMBER, "vertical pupils, widen to the side", // eyes
                    25, new Dictionary<BodyPartEnum, AppearanceFeatureEnum>() { { BodyPartEnum.TAIL, AppearanceFeatureEnum.NOTHING_SPECIAL} }, null); // age an general appearance

                case SpeciesEnum.LIZARDFOLK: return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.HARD_SOFT_DIFFERENCE, SkinTypeEnum.SCALES, ColorEnum.DARK_OLIVE, ColorEnum.OLIVE, 
                        "sturdy scales on the back and skin-like, softer scales on the chest and softer parts"), // skin 
                    new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.OLIVE, "horn-like scales instead of hair"), // hair
                    ColorEnum.OLIVE, "vertical pupils, widen to the sides", // eyes
                    25, new Dictionary<BodyPartEnum, AppearanceFeatureEnum>(){{ BodyPartEnum.TAIL, AppearanceFeatureEnum.NOTHING_SPECIAL}}, null); // age and general appearance

                case SpeciesEnum.ROBOT: return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, null, // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.METAL, ColorEnum.STEEL_GREY, ColorEnum.NONE, null), // skin
                    new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.NONE, null), // hair
                    ColorEnum.BLACK, null, // eyes
                    50, null, "robotic");

                case SpeciesEnum.SUPER_MUTANT: return new CharacterAppearance(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, "very big and bulky", // body type
                    new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.GREY, ColorEnum.NONE, null),
                    new Hair(),
                    ColorEnum.GREEN, null,
                    50, null, null);

                default: return new CharacterAppearance();
            }

            // ----------------------------------------------------------------------------------------------------------------------------
        }
    }
}
