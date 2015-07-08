using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z29
{
    class Loto
    {
        public Loto() { }

        public void generiranjeBrojeva(Form1 forma)
        {
            Random r = new Random();
            int noviBroj;
            int[] polje = new int[7];
            for (int i = 0; i < 7; i++)
            {
                noviBroj = r.Next(1, 39);
                if (polje.Contains(noviBroj))
                {
                    i--;
                }

                else polje[i] = noviBroj; 
            }
            forma.lbl1.Text = polje[0].ToString();
            forma.lbl2.Text = polje[1].ToString();
            forma.lbl3.Text = polje[2].ToString();
            forma.lbl4.Text = polje[3].ToString();
            forma.lbl5.Text = polje[4].ToString();
            forma.lbl6.Text = polje[5].ToString();
            forma.lbl7.Text = polje[6].ToString();

            foreach (Control label in forma.Controls)
            {
                if (label.GetType() == typeof(Label))
                {
                    if (int.Parse(label.Text) < 20)
                    {
                        label.ForeColor = Color.Green;
                    }
                    else label.ForeColor = Color.Red;
                }
            }
        }
    }
}
