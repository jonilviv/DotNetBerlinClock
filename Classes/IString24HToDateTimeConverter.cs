namespace BerlinClock.Classes
{
    public interface IString24HToBerlinClockConverter
    {
        BerlinClock Convert(string time24H);
    }
}