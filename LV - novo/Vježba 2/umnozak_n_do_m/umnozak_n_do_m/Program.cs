using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umnozak_n_do_m
{
    class Umnozak
    {
        public int dg;
        public int gg;
        public double rez=1;
        public string pom;

        public void unos()
        {
            Console.WriteLine("Unesite donju granicu: ");
            pom = Console.ReadLine();
            dg = int.Parse(pom);
            Console.WriteLine("Unesite gornju granicu: ");
            pom = Console.ReadLine();
            gg = int.Parse(pom);
        }

        public void ispis()
        {
            for (int i = dg; i <= gg; i++)
                rez *= i;
            Console.Write("Umnozak brojeva od N do M je: ");
            Console.WriteLine(rez);
            rez = 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Umnozak u1 = new Umnozak();
            Umnozak u2 = new Umnozak();
            int izbor;
            string pomocni;
            do
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine("1. Unos N i M. ");
                Console.WriteLine("2. Ispis rezultata: ");
                Console.WriteLine("0. Izlaz: ");
                Console.WriteLine("Vas izbor: ");
                pomocni = Console.ReadLine();
                izbor = int.Parse(pomocni);
                switch (izbor)
                {
                    case 1:
                        u1.unos();
                        break;

                    case 2:
                        u1.ispis();
                        break;
                }
            } while (izbor != 0);
        }
    }
}
