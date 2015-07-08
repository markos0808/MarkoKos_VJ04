using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.numericUpDownA.Minimum = 1;
            this.numericUpDownA.Maximum = 12;
            this.numericUpDownB.Minimum = 1;
            this.numericUpDownB.Maximum = 12;
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(numericUpDownA.Value);
            int v2 = Convert.ToInt32(numericUpDownB.Value);

            Mjesec mj = new Mjesec(v1, v2);
            lblIzmedju.Text = (mj.popMj().ToString());
        }


    }
}
