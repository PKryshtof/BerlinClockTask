using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class CustomBerlinClock
    {
        private const int TopRowWage = 5;
        private const int BottomRowWage = 1;
        private const int DefaultRowSize = 4;
        private const int QuadranceRowSize = 11;
        private const int HoursIndex = 0;
        private const int MinutesIndex = 1;
        private const int SecondsIndex = 2;
        private const char TimeDelimeter =':';

        private Bulp secondBulp;
        private TimeRow fiveHrRow;
        private TimeRow oneHrRow;
        private TimeRow quadranceRow;
        private TimeRow minuteRow;

        public CustomBerlinClock()
        {
            secondBulp = new Bulp(BulpColors.Yellow);
            fiveHrRow = new TimeRow(DefaultRowSize, BulpColors.Red, false);
            oneHrRow = new TimeRow(DefaultRowSize, BulpColors.Red, false);
            quadranceRow = new TimeRow(QuadranceRowSize, BulpColors.Yellow, true);
            minuteRow = new TimeRow(DefaultRowSize, BulpColors.Yellow, false);
        }

        public string ConvertTime(string time)
        {
            var timeSet = time.Split(TimeDelimeter);

            SetFiveHrRow(int.Parse(timeSet[HoursIndex]));
            SetOneHrRow(int.Parse(timeSet[HoursIndex]));
            SetQuadranceRow(int.Parse(timeSet[MinutesIndex]));
            SetMinuteRow(int.Parse(timeSet[MinutesIndex]));
            SetBulp(int.Parse(timeSet[SecondsIndex]));

            return this.ToString();
        }
        public override string ToString()
        {
            StringBuilder clockString = new StringBuilder();

            clockString.AppendLine(secondBulp.ToString());
            clockString.AppendLine(fiveHrRow.ToString());
            clockString.AppendLine(oneHrRow.ToString());
            clockString.AppendLine(quadranceRow.ToString());
            clockString.Append(minuteRow.ToString());

            return clockString.ToString();
        }

        private void SetFiveHrRow(int hours)
        {
            SetTimeRow(fiveHrRow, hours, TopRowWage);
        }
        private void SetOneHrRow(int hours)
        {
            SetTimeRow(oneHrRow, hours % TopRowWage, BottomRowWage);
        }
        private void SetQuadranceRow(int minutes)
        {
            SetTimeRow(quadranceRow, minutes, TopRowWage);
        }
        private void SetMinuteRow(int minutes)
        {
            SetTimeRow(minuteRow, minutes % TopRowWage, BottomRowWage);
        }
        private void SetBulp(int seconds)
        {
            secondBulp.ChangeState(seconds % 2 == 0 ? true : false);
        }
        private void SetTimeRow(TimeRow row, int ticks, int wage)
        {
            for (int i = 0; i < row.bulpRow.Length; i++)
            {
                if (ticks >= wage)
                {
                    row.bulpRow[i].ChangeState(true);
                    ticks -= wage;
                }
                else
                {
                    row.bulpRow[i].ChangeState(false);
                }
            }
        }
    }
}
