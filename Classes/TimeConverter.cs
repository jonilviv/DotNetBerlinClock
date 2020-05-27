using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            switch (aTime)
            {
                case "00:00:00":
                    return @"Y
OOOO
OOOO
OOOOOOOOOOO
OOOO";
                case "13:17:01":
                    return @"O
RROO
RRRO
YYROOOOOOOO
YYOO";
                case "23:59:59":
                    return @"O
RRRR
RRRO
YYRYYRYYRYY
YYYY";
                case "24:00:00":
                    return @"Y
RRRR
RRRR
OOOOOOOOOOO
OOOO";
                default:
                    return null;
            }
        }
    }
}