using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_3
{
    public partial class Form1 : Form
    {
        List<Vozilo> vozilaUGarazi = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
        }

        public void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivVozila.Text;
            string tipMotora = "Motocikl";
            string tipAutomobila = "Automobil";

            
            
            Automobil auto = new Automobil(naziv, tipAutomobila);
            Motocikl motor = new Motocikl(naziv, tipMotora);
            
            

            if (rbtnAuto.Checked)
            {            
                vozilaUGarazi.Add(auto);  
            }

            else if (rbtnMoto.Checked)
            {
                vozilaUGarazi.Add(motor); 
            }

            
            OsvjeziPrikaz();
            txtNazivVozila.Clear();
            
        }

        public void OsvjeziPrikaz()
        {
            listBoxVozilaUGarazi.Items.Clear();
            listBoxVozilaUGarazi.Update();
            int broj_auta = 0;
            int broj_motora = 0;


            foreach (Vozilo voz in vozilaUGarazi)
            {
                listBoxVozilaUGarazi.Items.Add(voz.Naziv + ":" + voz.TipVozila);

                if (voz.TipVozila == "Automobil")
                {
                    broj_auta++;
                    lblUkupnoA.Text = broj_auta.ToString();
                }

                else if (voz.TipVozila == "Motocikl")
                {
                    broj_motora++;
                    lblUkupnoM.Text = broj_motora.ToString();
                }
            }

               
            listBoxVozilaUGarazi.Update();
        }
    }
    }