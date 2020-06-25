using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeRow:TimeRowBase
    {
        public TimeRow(int rowSize, BulpColors color, bool withQuadrance):base(rowSize)
        {
            if(withQuadrance)
            {
                for (int i = 0; i < rowSize; i++)
                {
                    bulpRow[i] = (i+1)%3 == 0 ? new Bulp(BulpColors.Red) : new Bulp(color);
                }
            }
            else
            {
                for (int i = 0; i < rowSize; i++)
                {
                    bulpRow[i] = new Bulp(color);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder timeRow = new StringBuilder();
            foreach(var bulp in bulpRow)
            {
                timeRow.Append(bulp.ToString());
            }
            return timeRow.ToString();
        }

    }
}
