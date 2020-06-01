using System;

namespace BerlinClock.Classes
{
    [Serializable]
    public class InvalidTimeFormat : Exception
    {
        public override string Message
        {
            get
            {
                return CommonResources.InvalidTimeFormat;
            }
        }
    }
}