using BerlinClock.Classes;
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
            var customClock = new CustomBerlinClock();
            return customClock.ConvertTime(aTime);
        }
    }
}
