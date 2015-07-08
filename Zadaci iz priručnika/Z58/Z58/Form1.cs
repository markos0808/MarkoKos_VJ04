using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            Krug krug = new Krug(int.Parse(txtPolumjer.Text));
            txtOpseg.Text = krug.IzracunajOpseg().ToString();
            txtPovrsina.Text = krug.IzracunajPovrsinu().ToString();
        }
    }
}
