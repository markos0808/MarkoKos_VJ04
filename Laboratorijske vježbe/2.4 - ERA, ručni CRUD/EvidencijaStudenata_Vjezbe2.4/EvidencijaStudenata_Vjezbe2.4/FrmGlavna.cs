using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvidencijaStudenata_Vjezbe2._4
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            OsvjeziTimove();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            FrmNoviTim frmNoviTim = new FrmNoviTim();
            frmNoviTim.ShowDialog();
            OsvjeziTimove();

        }

        private void OsvjeziTimove()
        {
            List<Tim> listaTimova = Tim.DohvatiTimove();
            dgvTimovi.DataSource = listaTimova;
        }

        private void OsvjeziStudente(Tim odabraniTim)
        {
            List<Student> listaStudenata = Student.DohvatiStudente(odabraniTim);
            dgvStudenti.DataSource = listaStudenata;
        }

        private void btnIzmijeniTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                FrmNoviTim frmNoviTim = new FrmNoviTim(odabraniTim);
                frmNoviTim.ShowDialog();
                OsvjeziTimove();
            }
        }

        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTimovi.SelectedRows)
                {
                    Tim odabraniTim = row.DataBoundItem as Tim;
                    odabraniTim.Obrisi();
                }
            }

            OsvjeziTimove();
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
            FrmNoviStudent frmNoviStudent = new FrmNoviStudent();
            frmNoviStudent.ShowDialog();
            OsvjeziStudente(odabraniTim);
        }

        private void dgvTimovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                OsvjeziStudente(odabraniTim);
            }
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvStudenti.SelectedRows)
                {
                    Student odabraniStudent = row.DataBoundItem as Student;
                    odabraniStudent.Obrisi();
                }
            }


            if (dgvTimovi.SelectedRows.Count > 0)
            {
                OsvjeziStudente(dgvTimovi.SelectedRows[0].DataBoundItem as Tim);
            }
        }

        private void btnIzmijeniStudenta_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                Student odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                FrmNoviStudent frmNoviStudent = new FrmNoviStudent(odabraniStudent);
                frmNoviStudent.ShowDialog();
                OsvjeziStudente(odabraniTim);
            }
        }
    }
}
