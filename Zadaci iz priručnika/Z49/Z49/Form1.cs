using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            BrojSlova bs = new BrojSlova();
            List<Slovo> slova = bs.PobrojiSlova(txtTekst.Text);
            string poruka = "";
            foreach (Slovo slovo in slova)
            {
                poruka += slovo.znak + "=" + slovo.brojPonavljanja.ToString() + Environment.NewLine;
            }
            MessageBox.Show(poruka);
        }
    }
}
