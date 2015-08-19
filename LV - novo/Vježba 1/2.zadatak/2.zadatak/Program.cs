using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.zadatak
{
    class Program
    {
        static void Main()
        {
            List<Automobil> auto = new List<Automobil>();
            int izbor = 1;
            string pom;
            while (izbor != 0)
            {
                Console.WriteLine("0-izlaz  1-unos  2-ispis: ");
                Console.WriteLine("__________________________ ");
                pom = Console.ReadLine();
                izbor = int.Parse(pom);
                switch (izbor)
                {
                    case 1:
                        Automobil autek = new Automobil();
                        autek.Unos();
                        auto.Add(autek);
                        break;

                    case 2:
                        foreach (Automobil a in auto)
                            a.Ispis();
                        break;
                }
            }
        }
    }
}
