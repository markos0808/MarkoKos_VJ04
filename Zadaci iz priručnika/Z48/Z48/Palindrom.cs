using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z48
{
    class Palindrom
    {
        public Palindrom() { }

        public void provjeriPalindrom(Form1 forma)
        {
            bool pal = true;

            for (int i = 0; i < forma.txtRijec.Text.Length; i++)
            {
                if (forma.txtRijec.Text[i] != forma.txtRijec.Text[forma.txtRijec.Text.Length - 1 - i])
                {
                    pal = false;
                }

            }

            if (pal == false)
            {
                MessageBox.Show("NE!");
            }

            else if (pal == true)
                MessageBox.Show("DA!");         
        }
    }
}
