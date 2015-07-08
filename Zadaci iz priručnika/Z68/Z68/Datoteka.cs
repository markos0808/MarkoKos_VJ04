using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z68
{
    class Datoteka
    {
        public Datoteka() { }

        public void otvori(Form1 forma)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader strim = new StreamReader(dialog.FileName))
                {
                    forma.txtPopis.Text = strim.ReadToEnd();
                }
            }
        }
    }
}
