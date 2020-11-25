using PAPI.DataTypes;
using PAPI.Settings;
using System.Collections.Generic;

namespace PAPI.Character.Skill
{
    public class PAPISkill
    {
        // The name of the skill; as there are specific skills that reoccur in many genres, it is an enum
        private SkillEnum m_enum;

        // The type of the skill; e.g. General, Knowledge, Social, and others
        private SkillTypeEnum m_typeEnum;

        // The trained value of the skill
        private uint m_value;

        // The needed characteristic for the skill
        private CharacteristicEnum m_characteristic;

        // A list of all genres in which the skill is available
        private List<GenreEnum> m_availableGenres;

        // The Modification on the value of the skill
        private Modification m_modification;

        // Marker if the skills is a careerskill of this character
        private bool m_isCareer;

        // Min and max for value
        private const uint MIN_VALUE = 0;
        private const uint MAX_VALUE = 5;

        // ################################################# CTOR #################################################
        // A skill is constructed without value and modification; these have to be added manually
        public PAPISkill(SkillEnum skill, SkillTypeEnum type, CharacteristicEnum characteristic, List<GenreEnum> genres)
        {
            m_enum = skill;
            m_value = 0;
            m_characteristic = characteristic;
            m_availableGenres = genres;
            m_modification = new Modification();
            m_isCareer = false;
            m_typeEnum = type;
        }

        public PAPISkill(SkillEnum skill, SkillTypeEnum type, CharacteristicEnum characterisitc) : this(skill, type, characterisitc, GameSettings.GetAllGenres())
        { }

        

        // ################################################# GETTER #################################################


        // ################################################# SETTER #################################################

    }


}