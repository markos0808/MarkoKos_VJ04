using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z22
{
    class Slika
    {
        public Slika() { }

        public void otvaranjeDialoga(Form1 forma)
        {
            forma.openFileDialog1.ShowDialog();
        }

        public void ucitavanjeSlike(Form1 forma)
        {
            forma.pictureBox.Load(forma.openFileDialog1.FileName);
        }
    }
}
