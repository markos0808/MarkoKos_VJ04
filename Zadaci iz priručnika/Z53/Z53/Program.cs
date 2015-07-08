using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z53
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mjesec> popisMjeseca = new List<Mjesec>();
            Mjesec ve = new Mjesec(2, "Veljača", 28);
            Mjesec oz = new Mjesec(3, "Ožujak", 31);
            Mjesec tr = new Mjesec(4, "Travanj", 30);
            Mjesec sv = new Mjesec(5, "Svibanj", 31);
            Mjesec lp = new Mjesec(6, "Lipanj", 30);
            Mjesec sr = new Mjesec(7, "Srpanj", 31);
            Mjesec ko = new Mjesec(8, "Kolovoz", 30);
            Mjesec ru = new Mjesec(9, "Rujan", 31);
            Mjesec li = new Mjesec(10, "Listopad", 30);
            Mjesec st = new Mjesec(11, "Studeni", 31);
            Mjesec pr = new Mjesec(12, "Prosinac", 30);
            Mjesec sj = new Mjesec(1, "Siječanj", 31);

            popisMjeseca.Add(ve);
            popisMjeseca.Add(oz);
            popisMjeseca.Add(tr);
            popisMjeseca.Add(sv);
            popisMjeseca.Add(lp);
            popisMjeseca.Add(sr);
            popisMjeseca.Add(ko);
            popisMjeseca.Add(ru);
            popisMjeseca.Add(lp);
            popisMjeseca.Add(st);
            popisMjeseca.Add(pr);
            popisMjeseca.Add(sj);

            List<Mjesec> raspon = new List<Mjesec>();
            raspon = Mjesec.izracunSemestra(popisMjeseca, ve, lp);
            Console.WriteLine("Mjeseci ljetnog semestra: ");
            int zbrojDana = 0;

            foreach (Mjesec mjesec in raspon)
            {
                mjesec.ispis();
                zbrojDana += mjesec.get_brojDana();
            }

            Console.WriteLine("Broj dana semestra: " + zbrojDana.ToString());

            int zbrojDana2 = 31;
            List<Mjesec> raspon2 = new List<Mjesec>();
            raspon2 = Mjesec.izracunSemestra(popisMjeseca, ru, sj);
            Console.WriteLine("Mjeseci zimskog semestra: ");
            
            foreach (Mjesec mjesec2 in raspon)
            {
                mjesec2.ispis();
                zbrojDana2 += mjesec2.get_brojDana();
            }

            Console.WriteLine("Broj dana semestra: " + zbrojDana2.ToString());
            Console.ReadLine();

            
        }
    }
}
