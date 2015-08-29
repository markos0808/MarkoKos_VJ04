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

        public MyColor(frmMain forma, int prvi, int drugi, int treci, string cetvrti)
        {
            this.Red = prvi;
            this.Green = drugi;
            this.Blue = treci;
            this.Name = cetvrti;
        }

        public System.Drawing.Color FromArgb2(frmMain forma, int prvi, int drugi, int treci, string cetvrti)
        {
            this.Red = prvi;
            this.Green = drugi;
            this.Blue = treci;
            this.Name = cetvrti;
            return Color.FromArgb(prvi, drugi, treci);
        }


        
        



    }
  
}
