using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndodajBoje_Click(object sender, EventArgs e)
        {
            int r = int.Parse(txtR.Text);
            int g = int.Parse(txtG.Text);
            int b = int.Parse(txtB.Text);

            Boja boja = new Boja(r,g,b);
            boja.proracunBoje(this);
        }
    }
}
