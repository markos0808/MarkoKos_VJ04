using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rok
{
    class IspitniRok
    {
        public string NazivPredmeta { get; set; }
        public string NazivRoka { get; set; }
        public DateTime Datum { get; set; }
        List<Pitanje> Pitanja = new List<Pitanje>();

        public IspitniRok(string jedan, string dva, DateTime tri)
        {
            this.NazivPredmeta = jedan;
            this.NazivRoka = dva;
            this.Datum = tri;
        }

        public void DodajPitanje(frmUnosPitanja forma, Pitanje nPitanje)
        {
            string pit = forma.txtTekstPitanja.Text;
            string bod = forma.txtBrojBodova.Text;

            Pitanje pitanje = new Pitanje(pit, bod);
            Pitanja.Add(pitanje);


        }
    }

    
}
