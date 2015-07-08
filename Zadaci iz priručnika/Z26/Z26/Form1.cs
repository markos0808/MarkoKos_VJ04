using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sekunde = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekunde -= 1;
            Ugasi ug = new Ugasi(sekunde);
            this.btnUgasi.Text = ug.brojSekunda(this).ToString();

            if (ug.brojSekunda(this) == 0)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
