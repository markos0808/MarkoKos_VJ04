using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z34
{
    class Strane
    {
        public Strane() { }

        public void straneSvijeta(Form1 forma, MouseEventArgs e)
        {
            forma.lblKvadrant.Text = "";
            int xSredina = (forma.Width / 2) - 10;
            int ySredina = (forma.Height / 2) - 25;

            if (e.Y <= ySredina) forma.lblKvadrant.Text += "S";
            else forma.lblKvadrant.Text += "J";

            if (e.X <= xSredina) forma.lblKvadrant.Text += "Z";
            else forma.lblKvadrant.Text += "I";

            switch (forma.lblKvadrant.Text)
            {
                case "SZ": forma.BackColor = Color.Green;
                    break;
                case "SI": forma.BackColor = Color.Blue;
                    break;
                case "JZ": forma.BackColor = Color.Red;
                    break;
                case "JI": forma.BackColor = Color.Yellow;
                    break;
                default:
                    break;



            }
        }
    }
}
