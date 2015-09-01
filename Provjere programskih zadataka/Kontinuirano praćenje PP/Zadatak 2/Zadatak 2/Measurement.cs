using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class Measurement
    {
        public string Name { get; set; }
        public int Temperature { get; set; }
        public DateTime Time { get; set; }

        public Measurement(string naziv, int temperatura, DateTime vrijeme)
        {
            this.Name = naziv;
            this.Temperature = temperatura;
            this.Time = vrijeme;
        }

    }
}
