using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z63
{
    class Zapis
    {
        public Zapis() { }

        public void Pisi(Form1 forma)
        {
            StreamWriter zapisi = File.AppendText("E:\\" + forma.txtPutanja.Text + ".txt");
            zapisi.WriteLine(DateTime.Now.ToString());
            zapisi.Close();
        }
    }
}
