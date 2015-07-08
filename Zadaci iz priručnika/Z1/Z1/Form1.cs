using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1
{
    public partial class Form1 : Form
    {
        public static int brojForme = 1;

        public Form1()
        {
            InitializeComponent();
            this.button1.Text = Form1.brojForme.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaForma nF = new NovaForma();
            nF.Izracun();
        }
    }
}
