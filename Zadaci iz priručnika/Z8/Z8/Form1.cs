using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            string a = txtA.Text;
            string b = txtB.Text;
            string c = txtC.Text;

            Zamjena z = new Zamjena(a, b, c);
            txtC.Text = z.zamjenaPozicija();
        }
    }
}
