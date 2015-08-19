using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.zadatak
{
    class Automobil
    {
        public int Sasija;
        public string Marka;
        public string Model;
        public double C02;
        public string pom;


        public void Unos()
        {
            Console.WriteLine("--- I Z B O R N I K ---");
            
            Console.WriteLine("Unesite broj sasije: ");
            pom = Console.ReadLine();
            Sasija = int.Parse(pom);

            Console.WriteLine("Unesite marku automobila: ");
            Marka = Console.ReadLine();

            Console.WriteLine("Unesite model automobila: ");
            Model = Console.ReadLine();

            Console.WriteLine("Unesite C02 (g/km): ");
            pom = Console.ReadLine();
            C02 = int.Parse(pom);
        }


        public void Ispis()
        {
            Console.WriteLine("_____________________________");
            
            Console.WriteLine("Broj sasije automobila je: ");
            Console.WriteLine(this.Sasija);

            Console.WriteLine("Marka automobila je: ");
            Console.WriteLine(this.Marka);

            Console.WriteLine("Model automobila je: ");
            Console.WriteLine(this.Model);

            Console.WriteLine("Ispusni plinovi C02 (g/km) iznose: ");
            Console.WriteLine(this.C02);

            Console.WriteLine("_____________________________");

        }
    }

}
