using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakt
{
    public partial class FrmGlavna : Form
    {
        List<Contact> kontakt = new List<Contact>();

        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void Omoguci()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                }
            }
        }

        private void Onemoguci()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }
            }
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            Onemoguci();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            Omoguci();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string j = txtIme.Text;
            string d = txtPrezime.Text;
            string t = txtEmail.Text;
            string c = txtTelefon.Text;

            Onemoguci();

            Contact cc = new Contact(j, d, t, c);
            kontakt.Add(cc);
            listBoxPopisKontakata.Items.Add(j + " " + d);
        }

        private void listBoxPopisKontakata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPopisKontakata.SelectedItems.Count > 0)
            {
               
            }
        }
    }
}
