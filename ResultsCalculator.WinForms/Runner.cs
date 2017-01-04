using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsCalculator.WinForms
{
    public class Runner
    {
        public string Name;
        public DateTime StartTime;
        public DateTime EndTime;
        public TimeSpan TotalTime { get { return EndTime - StartTime; } }
        public int TotalLaps 
        {
            get { return totalLaps; }
            set { totalLaps = value; } 
            //TODO: do something fancy to check user provided totalLaps against the laps in the Laps list
        }

        private int totalLaps;

        public List<Lap> Laps = new List<Lap>();

        public Lap GetLap(int LapNumber)
        {
            for (int i = Laps.Count - 1; i >= 0; i--)
            {
                if (Laps[i].LapNumber == LapNumber)
                {
                    return Laps[i];
                }
            }
            throw new Exception("Lap was not found");
        }

        public void AddLap(Lap LapToAdd)
        {
            Laps.Add(LapToAdd);
        }
    }
}
