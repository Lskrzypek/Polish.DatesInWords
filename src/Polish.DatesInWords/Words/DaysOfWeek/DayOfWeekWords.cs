using Polish.NumbersInWords;

namespace Polish.DatesInWords.Words.DaysOfWeek
{
    internal static class DayOfWeekWords
    {
        public static IPhrase GetDayInWeek(System.DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case System.DayOfWeek.Monday: return new Monday();
                case System.DayOfWeek.Tuesday: return new Tuesday();
                case System.DayOfWeek.Wednesday: return new Wednesday();
                case System.DayOfWeek.Thursday: return new Thursday();
                case System.DayOfWeek.Friday: return new Friday();
                case System.DayOfWeek.Saturday: return new Saturday();
                case System.DayOfWeek.Sunday: return new Sunday();
                default: throw new System.Exception($"Unknown number of day of week: {dayOfWeek}");
            }
        }
    }
}
