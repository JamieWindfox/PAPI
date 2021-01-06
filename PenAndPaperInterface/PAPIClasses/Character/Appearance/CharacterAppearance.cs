
using PAPI.DataTypes;
using PAPI.Logging;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.Appearance
{
    public class CharacterAppearance
    {
        // Body Type
        public BodyHeightEnum _bodyHeight { get; private set; }
        public BodyTypeEnum _bodyType { get; private set; }
        public string _bodyTypeDescription { get; private set; }

        // Skin
       public Skin _skin { get; private set; }

        // Hair
        public Hair _hair { get; private set; }

        // Eyes
        public ColorEnum _eyeColor { get; private set; }
        public string _eyeDescription { get; private set; }

        // Age
        public uint _ageInYears { get; private set; }

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
        /// <param name="_skin">the skin/fur/scales/feathers/..., if null, the standard for a human is set</param>
        /// <param name="_hair">hair, if null, the character is bald</param>
        /// <param name="_eyeColor">what color do the irises have?</param>
        /// <param name="_eyeDescription">descriptiohn of the eyes, can be null</param>
        /// <param name="_ageInYears">The age of the character in years</param>
        /// <param name="_bodyPartFeatures">place for any other notable features regarding any given bodypart, can be null</param>
        /// <param name="_appearanceDescription">a short description of the overall appearance, can be null</param>
        [JsonConstructor]
        public CharacterAppearance(BodyHeightEnum _bodyHeight, BodyTypeEnum _bodyType, string _bodyTypeDescription, Skin _skin, Hair _hair, ColorEnum _eyeColor, 
            string _eyeDescription, uint _ageInYears, Dictionary<BodyPartEnum, AppearanceFeatureEnum> _bodyPartFeatures, string _appearanceDescription)
        {
            this._bodyHeight = _bodyHeight;
            this._bodyType = _bodyType;
            this._skin = (_skin == null) ? new Skin(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.MEDIUM_FLESH, ColorEnum.MEDIUM_FLESH, "") : _skin;
            this._hair = (_hair == null) ? new Hair(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.BROWN, null) : _hair;
            this._eyeColor = _eyeColor;
            this._ageInYears = _ageInYears;

            this._bodyTypeDescription = (_bodyTypeDescription == null) ? "" : _bodyTypeDescription;
            this._eyeDescription = (_eyeDescription == null) ? "" : _eyeDescription;
            this._appearanceDescription = (_appearanceDescription == null) ? "" : _appearanceDescription;

            this._bodyPartFeatures = (_bodyPartFeatures == null) ? new Dictionary<BodyPartEnum, AppearanceFeatureEnum>() : _bodyPartFeatures;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character Appearance with all members");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// An empty CTOR makes a very average appearance with medium flesh skin, brown eyes and no hair
        /// </summary>
        public CharacterAppearance() : this(BodyHeightEnum.AVERAGE, BodyTypeEnum.AVERAGE, "", null, null, ColorEnum.BROWN, "", 30, null, "")
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character Appearance from default CTOR");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Copy CTOR
        /// </summary>
        public CharacterAppearance(CharacterAppearance other) : this()
        {
            if (other == null) return;

            _bodyHeight = other._bodyHeight;
            _bodyType = other._bodyType;
            _bodyTypeDescription = other._bodyTypeDescription;
            _skin = new Skin(other._skin);
            _hair = new Hair(other._hair);
            _eyeColor = other._eyeColor;
            _eyeDescription = other._eyeDescription;
            _ageInYears = other._ageInYears;
            _bodyPartFeatures = new Dictionary<BodyPartEnum, AppearanceFeatureEnum>(other._bodyPartFeatures);
            _appearanceDescription = other._appearanceDescription;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Character Appearance from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the body type to the given value
        /// </summary>
        /// <param name="newBodyType">all BodyTypeEnum values are valid</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeBodyType(BodyTypeEnum newBodyType)
        {
            if(newBodyType == _bodyType)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change body type, because it already was " + this._bodyType);
                return false;
            }
            _bodyType = newBodyType;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed body type to " + this._bodyType);
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the body type description to the given value
        /// </summary>
        /// <param name="newDescription">if null or empty, the description is empty (if there was one before, it gets cleared)</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeBodyTypeDescription(string newDescription)
        {
            if (newDescription != null && newDescription == _bodyTypeDescription)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change body type description, because it already was " + this._bodyTypeDescription);
                return false;
            }
            _bodyTypeDescription = (newDescription == null) ? "" : newDescription;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed body type description to " + this._bodyTypeDescription);
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Increases the age in years by one
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool AgeOneYear()
        {
            _ageInYears++;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed age to " + this._ageInYears);
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Adds a special feature to the given body part; if it already has a feature, the old one gets overwritten
        /// </summary>
        /// <param name="bodyPart"></param>
        /// <param name="feature"></param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddSpecialFeature(BodyPartEnum bodyPart, AppearanceFeatureEnum feature)
        {
            if(_bodyPartFeatures.ContainsKey(bodyPart))
            {
                _bodyPartFeatures[bodyPart] = feature;
                WfLogger.Log(this, LogLevel.DEBUG, "Added body part " + bodyPart + " with feature " + feature);
            }
            else
            {
                _bodyPartFeatures.Add(bodyPart, feature);
                WfLogger.Log(this, LogLevel.DEBUG, "Changed body part " + bodyPart + " to feature " + feature);
            }
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public bool ChangeHair(Hair newHair)
        {
            if (newHair != null && newHair == _hair)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change hair, because it already was the given value");
                return false;
            }
            _hair.ChangeStyle(newHair._style);
            _hair.ChangeLength(newHair._length);
            _hair.ChangeColor(newHair._color);
            _hair.ChangeDescription(newHair._description);

            WfLogger.Log(this, LogLevel.DEBUG, "Changed hair");
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the general appearance description to the given value
        /// </summary>
        /// <param name="newDescription"></param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeAppearanceDescription(string newDescription)
        {
            if (newDescription != null &&  newDescription == _appearanceDescription)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change general appearance description, because it already was " + this._appearanceDescription);
                return false;
            }
            _appearanceDescription = (newDescription == null) ? "" : newDescription;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed general appearance description to " + this._appearanceDescription);
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
