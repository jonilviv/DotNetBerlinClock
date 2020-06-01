using System.Diagnostics.CodeAnalysis;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IString24HToBerlinClockConverter _string24HToBerlinClockConverter;

        public TimeConverter()
        {
            _string24HToBerlinClockConverter = new String24HToBerlinClockConverter();
        }

        [ExcludeFromCodeCoverage]
        public TimeConverter(IString24HToBerlinClockConverter string24HToBerlinClockConverter)
        {
            _string24HToBerlinClockConverter = string24HToBerlinClockConverter;
        }

        public string ConvertTime(string aTime)
        {
            BerlinClock berlinClock = _string24HToBerlinClockConverter.Convert(aTime);

            string time = berlinClock.ToString();

            return time;
        }
    }
}