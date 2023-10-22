using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForekBase.Domain.Entities.Enums
{
    public enum QuestionType
    {
        MultipleChoice,
        Rating,
        OpenText,
        Binary,
    }

    public enum eRace
    {
        African,
        Indian,
        White,
        Coloured,

    }
    public enum eGender
    {
        Male,
        Female,
    }

    public enum AgeRange
    {
        [Display(Name ="18 - 25")]
        EighteenToTwentyfive,

        [Display(Name = "26 - 35")]
        TwentysixToThirtyfive,

        [Display(Name = "36 - 50")]
        ThirtysixToFifty,

        [Display(Name = "51 - 60")]
        FiftyoneToSixty,

        [Display(Name = "61 - 70")]
        SixtyOneToSeventy,

    }

    public enum Qualification
    {
        Yes,
        No,
    }

    public enum QualificationType
    {
        Levels,
        Certificate,
        Diploma,
        Degree,
        BTech,
        Honours,
        Masters,
        Doctorate,
        PhD,

    }

    public enum eCitizen
    {
        Permanent,
        Temporary,
        NonCitizen
    }

    public enum eMunicipalityType
    {
        Metropolitan,
        District,
        Local,
    }

    public enum eMunicipality
    {
        Mbombela_Municipality,

        VictorKanye_Local_Municipality,

        Thabacheu_Municipality,

    }

    public enum eProvince
    {
        Mpumalanga,
        Limpopo,
        Gauteng,
        NorthWest,
        FreeState,
        NorthernCape,
        WesternCape,
        KwaZuluNatal,
        EasternCape,

    }

    public enum eCountry
    {
        SouthAfrica,

    }

    public enum eRatings
    {
        VerySatisfied,
        Satisfied,
        Moderate,
        DisSatisfied,
        VeryDisatisfied,
    }

    public enum eScale
    {
        One, 
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,

    }



}
