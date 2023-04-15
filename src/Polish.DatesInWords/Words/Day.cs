using Polish.NumbersInWords;

namespace Polish.DatesInWords.Words
{
    internal class Day : IPhrase
    {
        public string NominativeForm => "dzień";
        public string GenitiveForm => "dnia";
        public string DativeForm => "dniowi";
        public string AccusativeForm => "dzień";
        public string InstrumentalForm => "dniem";
        public string LocativeForm => "dniu";
        public string VocativeForm => "dniu";
        public string PluralNominativeForm => "dni";
        public string PluralGenitiveForm => "dni";
        public string PluralDativeForm => "dniom";
        public string PluralAccusativeForm => "dni";
        public string PluralInstrumentalForm => "dniami ";
        public string PluralLocativeForm => "dniach";
        public string PluralVocativeForm => "dni";
    }
}
