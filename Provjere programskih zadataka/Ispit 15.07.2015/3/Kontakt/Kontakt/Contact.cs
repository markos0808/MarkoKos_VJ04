using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakt
{
    class Contact
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }


        public Contact(string j, string d, string t, string c)
        {
            this.Ime = j;
            this.Prezime = d;
            this.Email = t;
            this.Telefon = c;
        }
    }
}
