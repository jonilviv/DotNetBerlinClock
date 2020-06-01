using System;

namespace BerlinClock.Classes
{
    [Serializable]
    public sealed class BerlinClock
    {
        public BerlinClock()
        {
        }

        public BerlinClock(DateTime dateTime)
            : this(dateTime.Hour, dateTime.Minute, dateTime.Second)
        {
        }

        public BerlinClock(int hour = 0, int minute = 0, int second = 0)
        {
            Hours5 = hour > 4;
            Hours10 = hour > 9;
            Hours15 = hour > 14;
            Hours20 = hour > 19;

            int sum = (Hours5 ? 5 : 0) + (Hours10 ? 5 : 0) + (Hours15 ? 5 : 0) + (Hours20 ? 5 : 0);
            int rest = hour - sum;

            Hour1 = rest > 0;
            Hour2 = rest > 1;
            Hour3 = rest > 2;
            Hour4 = rest > 3;

            Minutes5 = minute > 4;
            Minutes10 = minute > 9;
            Minutes15 = minute > 14;
            Minutes20 = minute > 19;
            Minutes25 = minute > 24;
            Minutes30 = minute > 29;
            Minutes35 = minute > 34;
            Minutes40 = minute > 39;
            Minutes45 = minute > 44;
            Minutes50 = minute > 49;
            Minutes55 = minute > 54;

            sum = (Minutes5 ? 5 : 0) + (Minutes10 ? 5 : 0) + (Minutes15 ? 5 : 0) + (Minutes20 ? 5 : 0) + (Minutes25 ? 5 : 0) + (Minutes30 ? 5 : 0) + (Minutes35 ? 5 : 0) + (Minutes40 ? 5 : 0) + (Minutes45 ? 5 : 0) + (Minutes50 ? 5 : 0) + (Minutes55 ? 5 : 0);
            rest = minute - sum;

            Minute1 = rest > 0;
            Minute2 = rest > 1;
            Minute3 = rest > 2;
            Minute4 = rest > 3;


            Second = second % 2 == 0;
        }

        public bool Second { get; set; }


        public bool Hours5 { get; set; }

        public bool Hours10 { get; set; }

        public bool Hours15 { get; set; }


        public bool Hours20 { get; set; }

        public bool Hour1 { get; set; }

        public bool Hour2 { get; set; }

        public bool Hour3 { get; set; }

        public bool Hour4 { get; set; }


        public bool Minutes5 { get; set; }

        public bool Minutes10 { get; set; }

        public bool Minutes15 { get; set; }

        public bool Minutes20 { get; set; }

        public bool Minutes25 { get; set; }

        public bool Minutes30 { get; set; }

        public bool Minutes35 { get; set; }

        public bool Minutes40 { get; set; }

        public bool Minutes45 { get; set; }

        public bool Minutes50 { get; set; }

        public bool Minutes55 { get; set; }


        public bool Minute1 { get; set; }

        public bool Minute2 { get; set; }

        public bool Minute3 { get; set; }

        public bool Minute4 { get; set; }


        public override string ToString()
        {
            string result = Second.YellowToString() + Environment.NewLine
                          + Hours5.RedToString() + Hours10.RedToString() + Hours15.RedToString() + Hours20.RedToString() + Environment.NewLine
                          + Hour1.RedToString() + Hour2.RedToString() + Hour3.RedToString() + Hour4.RedToString() + Environment.NewLine
                          + Minutes5.YellowToString() + Minutes10.YellowToString() + Minutes15.RedToString() + Minutes20.YellowToString() + Minutes25.YellowToString() + Minutes30.RedToString() + Minutes35.YellowToString() + Minutes40.YellowToString() + Minutes45.RedToString() + Minutes50.YellowToString() + Minutes55.YellowToString() + Environment.NewLine
                          + Minute1.YellowToString() + Minute2.YellowToString() + Minute3.YellowToString() + Minute4.YellowToString();

            return result;
        }
    }
}