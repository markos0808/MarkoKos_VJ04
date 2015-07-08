using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirektorij_Click(object sender, EventArgs e)
        {
            string direktorij = txtPutanja.Text;
            if (Directory.Exists(direktorij) == false)
            {
                MessageBox.Show("Direktorij ne postoji!");
            }

            else
            {
                string[] datoteke = Directory.GetFiles(direktorij);
                foreach (string data in datoteke)
                {
                    txtSadrzaj.Text += data.ToString();
                }
            }
        }
    }
}
