using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1_EvidencijaStudenataX
{
    public partial class FrmNoviStudent : Form
    {
        private Tim selektiraniTim;   //Atribut u koji ćemo pohraniti selektirani tim.

        public FrmNoviStudent(Tim tim)  //Formi prosljeđujemo selektirani tim.
        {
            InitializeComponent();
            selektiraniTim = tim;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmNoviStudent_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
            if (selektiraniTim != null)
            {
                txtTim.Text = selektiraniTim.OznakaTima;
            }
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Uredu.
        /// </summary>
        private void btnUredu_Click(object sender, EventArgs e)
        {
            using (var db = new EvidencijaStudenataEntities4())
            {
                //S obzirom da objekt selektiraniTim nije kreiran u
                //tekućem kontekstu, moramo ga "registrirati".
                db.Timovi.Attach(selektiraniTim);
                Student student = new Student       //Kreiramo novog studenta
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Status = txtStatus.Text,
                    OdabraniModel = txtOdabraniModel.Text,
                    Napomena = txtNapomena.Text,
                    Email = txtEmail.Text,
                    Tim = selektiraniTim
                };

                db.Studenti.Add(student);  //Dodajemo studenta u kolekciju.
                db.SaveChanges();          //Spremamo promjene u bazu podataka.
            }
            Close();
        }
    }
}
