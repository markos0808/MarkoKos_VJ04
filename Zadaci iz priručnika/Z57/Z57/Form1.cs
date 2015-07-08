using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float strA = int.Parse(txtA.Text);
            float strB = int.Parse(txtB.Text);
            float strC = int.Parse(txtC.Text);

            Trokut trokut = new Trokut(strA, strB, strC);
            txtO.Text = (trokut.IzracunajOpseg().ToString());
            txtP.Text = (trokut.IzracunajPovrsinu().ToString());
        }
    }
}
