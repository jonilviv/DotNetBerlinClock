namespace BerlinClock.Classes
{
    public static class BooleanTools
    {
        public static string RedToString(this bool val)
        {
            return val ? "R" : "O";
        }

        public static string YellowToString(this bool val)
        {
            return val ? "Y" : "O";
        }
    }
}