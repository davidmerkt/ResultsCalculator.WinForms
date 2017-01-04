using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsCalculator.WinForms
{
    public class Lap
    {
        //lap 7:00, 7:15, 7:25
        //split 7:00, 14:15, 21:40
        public int LapNumber;
        private TimeSpan lapTime;
        private TimeSpan splitTime;
        private DateTime splitTimeOfDay;

        public TimeSpan LapTime { get { return lapTime; } }
        public TimeSpan SplitTime { get { return splitTime; } }
        public DateTime SplitTimeOfDay { get { return splitTimeOfDay; } }

        public Lap(int LapNumber)
        {
            assignLapNumber(LapNumber);
        }

        private void assignLapNumber(int LapNumber)
        {
            if (LapNumber > 0)
                this.LapNumber = LapNumber;
            else
                throw new Exception("Laps must be numbered greater than 0");
        }

        public Lap(int LapNumber, int LapHour, int LapMinute, float LapSecond)
        {
            assignLapNumber(LapNumber);

            this.lapTime = TimeSpan.FromHours(LapHour) + TimeSpan.FromMinutes(LapMinute) + TimeSpan.FromSeconds(Math.Round(LapSecond,3));
        }

        public Lap(int LapNumber, ClockType ClockType, int Hour, int Minute, float Second)
        {
            assignLapNumber(LapNumber);

            if (ClockType == ClockType.Lap)
            {
                this.lapTime = TimeSpan.FromHours(Hour) + TimeSpan.FromMinutes(Minute) + TimeSpan.FromSeconds(Math.Round(Second, 3));
            }

            if (ClockType == ClockType.Split)
            {
                this.splitTime = TimeSpan.FromHours(Hour) + TimeSpan.FromMinutes(Minute) + TimeSpan.FromSeconds(Math.Round(Second, 3));
            }
        }

        public Lap(int LapNumber, DateTime SplitTimeOfDay, DateTime EventStartTime)
        {
            assignLapNumber(LapNumber);

            this.splitTimeOfDay = SplitTimeOfDay;

            this.splitTime = SplitTimeOfDay - EventStartTime;
        }
    }

    public enum ClockType { Lap, Split }
}
