using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public enum BulpColors
    {
        Yellow,
        Red
    }

    public static class BulpColorsExtension
    {
        private static string Yellow = "Y";
        private static string Red = "R";
        public static string ToBulpString(this BulpColors color)
        {
            switch(color)
            {
                case BulpColors.Red:
                    return Red;
                default:
                    return Yellow;
            }
        }
    }
}
