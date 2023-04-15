namespace Polish.DatesInWords
{
    internal static class CaseConverter
    {
        public static NumbersInWords.Case ToNumericCase(this DatesInWords.Case @case)
        {
            return (NumbersInWords.Case) @case;
        }
    }
}
