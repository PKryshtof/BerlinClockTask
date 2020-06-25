using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class Bulp
    {
        private static string offString = "O";
        private readonly BulpColors bulpColor;

        public Bulp(BulpColors bulpColor)
        {
            this.bulpColor = bulpColor;
        }

        public bool IsOn { get; private set; }

        public void ChangeState(bool isOnState)
        {
            IsOn = isOnState;
        }

        public override string ToString()
        {
            return IsOn ? bulpColor.ToBulpString() : offString;
        }
    }
}
