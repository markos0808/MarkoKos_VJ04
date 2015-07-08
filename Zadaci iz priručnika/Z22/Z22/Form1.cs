using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Slika s = new Slika();
            s.otvaranjeDialoga(this);
            openFileDialog1.FileOk+=openFileDialog1_FileOk;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Slika s = new Slika();
            s.ucitavanjeSlike(this);
        }
    }
}
