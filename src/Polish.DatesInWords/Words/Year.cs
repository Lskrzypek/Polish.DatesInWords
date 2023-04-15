using Polish.NumbersInWords;

namespace Polish.DatesInWords.Words
{
    internal class Year : IPhrase
    {
        public string NominativeForm => "rok";
        public string GenitiveForm => "roku";
        public string DativeForm => "rokowi";
        public string AccusativeForm => "rok";
        public string InstrumentalForm => "rokiem";
        public string LocativeForm => "roku";
        public string VocativeForm => "roku";
        public string PluralNominativeForm => "lata";
        public string PluralGenitiveForm => "lat";
        public string PluralDativeForm => "latom";
        public string PluralAccusativeForm => "lata";
        public string PluralInstrumentalForm => "latami ";
        public string PluralLocativeForm => "latach";
        public string PluralVocativeForm => "lata";
    }
}
