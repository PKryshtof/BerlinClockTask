using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeRowBase
    {
        protected readonly int rowSize;
        public Bulp[] bulpRow;

        public TimeRowBase(int rowSize)
        {
            this.rowSize = rowSize;
            bulpRow = new Bulp[rowSize];
        }
    }
}
