using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z20
{
    class GodisnjaDoba
    {
        public GodisnjaDoba() { }

        public void izracunGodDoba(Form1 forma)
        {
            DateTime d = forma.dateTimePicker.Value;
            if (d.Month <= 3)
            {
                if (d.Day >= 22 && d.Month == 3)
                {
                    forma.lblGodDoba.Text = "Proljeće";
                }
                else forma.lblGodDoba.Text = "Zima";
            }

            if (d.Month <= 6)
            {
                if (d.Day >= 22 && d.Month == 6)
                {
                    forma.lblGodDoba.Text = "Ljeto";
                }
                else forma.lblGodDoba.Text = "Proljeće";
            }

            if (d.Month <= 9)
            {
                if (d.Day >= 22 && d.Month == 9)
                {
                    forma.lblGodDoba.Text = "Jesen";
                }
                else forma.lblGodDoba.Text = "Ljeto";
            }
            else forma.lblGodDoba.Text = "Jesen";
        }
    }
}
