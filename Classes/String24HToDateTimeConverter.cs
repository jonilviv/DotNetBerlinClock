using System;

namespace BerlinClock.Classes
{
    public class String24HToBerlinClockConverter : IString24HToBerlinClockConverter
    {
        public BerlinClock Convert(string time24H)
        {
            if (string.IsNullOrWhiteSpace(time24H) || time24H.Length > 8)
            {
                throw new InvalidTimeFormat();
            }

            if (time24H == "24:00:00")//We need this check, because client ask about this value, that is incorrect as DateTime in C#
            {
                return new BerlinClock(24);
            }

            if (!DateTime.TryParse(time24H, out DateTime dateTime))
            {
                throw new InvalidTimeFormat();
            }

            return new BerlinClock(dateTime);
        }
    }
}