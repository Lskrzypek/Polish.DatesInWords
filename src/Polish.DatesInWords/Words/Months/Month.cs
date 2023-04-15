using Polish.NumbersInWords;

namespace Polish.DatesInWords.Words.Months
{
    internal static class Month
    {
        public static IPhrase GetMonth(int number)
        {
            switch (number)
            {
                case 1: return new January();
                case 2: return new February();
                case 3: return new March();
                case 4: return new April();
                case 5: return new May();
                case 6: return new June();
                case 7: return new July();
                case 8: return new August();
                case 9: return new September();
                case 10: return new October();
                case 11: return new November();
                case 12: return new December();
                default: throw new System.Exception($"Unknown number of month: {number}");
            }
        }
    }
}
