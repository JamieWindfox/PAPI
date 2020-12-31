
using PAPI.DataTypes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.Appearance
{
    public class CharacterAppearance
    {
        private CharacterAppearance characterAppearance;

        // Body Type
        public BodyHeightEnum _bodyHeight { get; private set; }
        public BodyTypeEnum _bodyType { get; private set; }
        public string _bodyTypeDescription { get; private set; }

        // Skin Type
        public SkinColorTypeEnum _skinColorType { get; private set; }
        public SkinTypeEnum _skinType { get; private set; }
        public ColorEnum _skinPrimaryColor { get; private set; }
        public ColorEnum _skinSecondaryColor { get; private set; }
        public string _skinDescription { get; private set; }

        // Hair
        public HairStyleEnum _hairStyle { get; private set; }
        public ColorEnum _hairColor { get; private set; }
        public string _hairDescription { get; private set; }

        // Eyes
        public ColorEnum _eyeColor { get; private set; }
        public string _eyeDescription { get; private set; }

        // Other Features
        public Dictionary<BodyPartEnum, AppearanceFeatureEnum> _bodyPartFeatures { get; private set; }
        public string _appearanceDescription { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON CTOR must contain all traits of the appearance
        /// </summary>
        /// <param name="_bodyHeight">in comparison to an average specimen of the same species</param>
        /// <param name="_bodyType">in comparison to an average specimen of the same species</param>
        /// <param name="_bodyTypeDescription">a description of the body tape, can be null</param>
        /// <param name="_skinColorType">enum if the skin/fur/Scale/... color is a single color or somehow has a pattern</param>
        /// <param name="_skinType">how is the body protected from the ouside</param>
        /// <param name="_skinPrimaryColor">what color does the skin have mostly?</param>
        /// <param name="_skinSecondaryColor">what color do the details of the skin pattern have?</param>
        /// <param name="_skinDescription">description of the skin/fur/scales/feathers/..., can be null</param>
        /// <param name="_hairStyle">in what style does the character wear their head-hair?</param>
        /// <param name="_hairColor">what color does the (most) head-hair of the character have?</param>
        /// <param name="_hairDescription">description of the hair, can be null</param>
        /// <param name="_eyeColor">what color do the irises have?</param>
        /// <param name="_eyeDescription">descriptiohn of the eyes, can be null</param>
        /// <param name="_bodyPartFeatures">place for any other notable features regarding any given bodypart, can be null</param>
        /// <param name="_appearanceDescription">a short description of the overall appearance, can be null</param>
        [JsonConstructor]
        public CharacterAppearance(BodyHeightEnum _bodyHeight, BodyTypeEnum _bodyType, string _bodyTypeDescription, SkinColorTypeEnum _skinColorType, SkinTypeEnum _skinType,
            ColorEnum _skinPrimaryColor, ColorEnum _skinSecondaryColor, string _skinDescription, HairStyleEnum _hairStyle, ColorEnum _hairColor, string _hairDescription,
            ColorEnum _eyeColor, string _eyeDescription, Dictionary<BodyPartEnum, AppearanceFeatureEnum> _bodyPartFeatures, string _appearanceDescription)
        {
            this._bodyHeight = _bodyHeight;
            this._bodyType = _bodyType;
            this._skinColorType = _skinColorType;
            this._skinType = _skinType;
            this._skinPrimaryColor = _skinPrimaryColor;
            this._skinSecondaryColor = _skinSecondaryColor;
            this._hairStyle = _hairStyle;
            this._hairColor = _hairColor;
            this._eyeColor = _eyeColor;

            this._bodyTypeDescription = (_bodyTypeDescription == null) ? "" : _bodyTypeDescription;
            this._skinDescription = (_skinDescription == null) ? "" : _skinDescription;
            this._hairDescription = (_hairDescription == null) ? "" : _hairDescription;
            this._eyeDescription = (_eyeDescription == null) ? "" : _eyeDescription;
            this._appearanceDescription = (_appearanceDescription == null) ? "" : _appearanceDescription;

            this._bodyPartFeatures = (_bodyPartFeatures == null) ? new Dictionary<BodyPartEnum, AppearanceFeatureEnum>() : _bodyPartFeatures;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// An empty CTOR makes a very average human appearance
        /// </summary>
        public CharacterAppearance() : this(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, "", SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.MEDIUM_FLESH,
            ColorEnum.NONE, "", HairStyleEnum.MEDIUM, ColorEnum.BROWN, "", ColorEnum.BROWN, "", null, "")
        { }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Copy CTOR
        /// </summary>
        public CharacterAppearance(CharacterAppearance other) : this(other._bodyHeight, other._bodyType, other._bodyTypeDescription, other._skinColorType, other._skinType,
            other._skinPrimaryColor, other._skinSecondaryColor, other._skinDescription, other._hairStyle, other._hairColor, other._hairDescription, other._eyeColor,
            other._eyeDescription, other._bodyPartFeatures, other._appearanceDescription)
        { }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
