using PAPI.DataTypes;
using PAPI.Logging;
using System.Text.Json.Serialization;

namespace PAPI.Character.Appearance
{
    /// <summary>
    /// Describes the skin of a character/ceature
    /// </summary>
    public class Skin
    {
        public SkinColorTypeEnum _colorType { get; private set; }
        public SkinTypeEnum _type { get; private set; }
        public ColorEnum _primaryColor { get; private set; }
        public ColorEnum _secondaryColor { get; private set; }
        public string _description { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The Json CTOR must contain all traits of a skin object
        /// </summary>
        /// <param name="_colorType">is the skin one color or petterned?</param>
        /// <param name="_type">what type of skin/protection?</param>
        /// <param name="_primaryColor">the main color of the skin</param>
        /// <param name="_secondaryColor">the secondary color of the skin, if none, it is automatically single-colored</param>
        /// <param name="_description">a short description, if null, there is none</param>
        [JsonConstructor]
        public Skin(SkinColorTypeEnum _colorType, SkinTypeEnum _type, ColorEnum _primaryColor, ColorEnum _secondaryColor, string _description)
        {
            this._colorType = _colorType;
            this._type = _type;
            this._primaryColor = _primaryColor;

            if(_secondaryColor == _primaryColor || _secondaryColor == ColorEnum.NONE)
            {
                this._colorType = SkinColorTypeEnum.SINGLE_COLOR;
            }
            this._secondaryColor = (this._colorType == SkinColorTypeEnum.SINGLE_COLOR) ? _primaryColor : _secondaryColor;
            this._description = (_description == null) ? "" : _description;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Skin (" + this._type + ", " + this._colorType + ", " + this._primaryColor + ", " + this._secondaryColor + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default CTOR makes Skin for an average human
        /// </summary>
        public Skin() : this(SkinColorTypeEnum.SINGLE_COLOR, SkinTypeEnum.SKIN, ColorEnum.MEDIUM_FLESH, ColorEnum.MEDIUM_FLESH, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Skin from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Skin(Skin other) : this()
        {
            if (other == null) return;

            _colorType = other._colorType;
            _type = other._type;
            _primaryColor = other._primaryColor;
            _secondaryColor = other._secondaryColor;
            _description = other._description;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Skin from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
