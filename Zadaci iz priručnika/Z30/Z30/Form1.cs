using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                this.cboxMjesec.Items.Add(i);
            }
        }

        private void cboxMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mjesec mjesec = new Mjesec();
            mjesec.pregledMjeseca(this);
        }
    }
}
