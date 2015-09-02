using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    class MyColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Name { get; set; }


        public MyColor(int red, int green, int blue, string name)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Name = name;
        }


        public System.Drawing.Color GetColor()
        {
            return System.Drawing.Color.FromArgb(Red, Green, Blue);
        }
    }
}
