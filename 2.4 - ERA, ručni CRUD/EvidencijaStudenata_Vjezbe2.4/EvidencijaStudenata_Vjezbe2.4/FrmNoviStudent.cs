using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvidencijaStudenata_Vjezbe2._4
{
    public partial class FrmNoviStudent : Form
    {
        private Student student = null;

        public FrmNoviStudent()
        {
            InitializeComponent();
        }

        public FrmNoviStudent(Student odabraniStudent)
        {
            InitializeComponent();
            student = odabraniStudent;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                student = new Student();
            }
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            
            if (rbtnRedoviti.Checked == true)
            {
                student.Status = char.Parse("R");
            }
            else
            {
                student.Status = char.Parse("I");
            }

            if (rbtnModelA.Checked == true)
            {
                student.OdabraniModel = char.Parse("A");
            }
            else
            {
                student.OdabraniModel = char.Parse("B");
            }

            student.Email = txtEmail.Text;
            student.Napomena = txtNapomena.Text;
            student.Tim = cmbTim.SelectedItem as Tim;
            student.Spremi();
            this.Close();
        }

        private void FrmNoviStudent_Load(object sender, EventArgs e)
        {
            cmbTim.DataSource = Tim.DohvatiTimove();
            if (student != null)
            {
                txtId.Text = student.Id.ToString();
                txtIme.Text = student.Ime;
                txtPrezime.Text = student.Prezime;
                txtEmail.Text = student.Email;
                txtNapomena.Text = student.Napomena;
                
                if (student.Status == char.Parse("R"))
                {
                    rbtnRedoviti.Checked = true;
                }
                else
                {
                    rbtnIzvanredni.Checked = true;
                }

                if (student.OdabraniModel == char.Parse("A"))
                {
                    rbtnModelA.Checked = true;
                }
                else
                {
                    rbtnModelB.Checked = true;
                }

                for (int i = 0; i < cmbTim.Items.Count; i++)
                {
                    cmbTim.SelectedIndex = i;
                    if ((cmbTim.SelectedItem as Tim).Id == student.Tim.Id)
                    {
                        break;
                    }
                }
            }
        }
    }
}
