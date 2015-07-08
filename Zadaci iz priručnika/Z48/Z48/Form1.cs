using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            Palindrom palindrom = new Palindrom();
            palindrom.provjeriPalindrom(this);
        }
    }
}
