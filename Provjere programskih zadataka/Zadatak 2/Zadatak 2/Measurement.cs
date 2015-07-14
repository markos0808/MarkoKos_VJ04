using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class Measurement
    {
        public string Name;
        public int Temperature;
        public DateTime Time;

        public Measurement(string naziv, int temperatura, DateTime vrijeme)
        {
            this.Name = naziv;
            this.Temperature = temperatura;
            this.Time = vrijeme;
        }

    }
}
