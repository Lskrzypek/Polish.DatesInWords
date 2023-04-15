using Polish.NumbersInWords;
using System.Collections.Generic;

namespace Polish.DatesInWords.Words
{
    internal static class YearWord
    {
        private static readonly Dictionary<Case, string> _singularCases = new Dictionary<Case, string>()
        {
            { Case.Nominative, "rok"},
            { Case.Genitive, "roku"},
            { Case.Dative, "rokowi"},
            { Case.Accusative, "rok"},
            { Case.Instrumental, "rokiem"},
            { Case.Locative, "roku"},
            { Case.Vocative, "roku"},
        };

        private static readonly Dictionary<Case, string> _pluralCases = new Dictionary<Case, string>()
        {
            { Case.Nominative, "lata"},
            { Case.Genitive, "lat"},
            { Case.Dative, "latom"},
            { Case.Accusative, "lata"},
            { Case.Instrumental, "latami"},
            { Case.Locative, "latach"},
            { Case.Vocative, "lata"},
        };

        public static string GetSingular(Case @case)
        {
            return _singularCases[@case];
        }

        public static string GetPlural(Case @case)
        {
            return _pluralCases[@case];
        }
    }
}
