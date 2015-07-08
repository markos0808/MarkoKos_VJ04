using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtVisina.Text);
            int b = int.Parse(txtSirina.Text);

            Pravokutnik pr = new Pravokutnik(a, b);
            txtPovrsina.Text = (pr.IzracunajPovrsinu().ToString());
            txtOpseg.Text = (pr.IzracunajOpseg().ToString());
            txtDijagonala.Text = (pr.IzracunajDijagonalu().ToString());
        }
    }
}
