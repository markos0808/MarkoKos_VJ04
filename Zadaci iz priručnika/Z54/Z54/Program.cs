using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z54
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] d = new float[12];
            string a;
            Zaposlenik zap = new Zaposlenik();
            Console.WriteLine("Unos podataka o zaposleniku: ");
            Console.WriteLine("Ime i prezime: ");
            zap.imePrezime = Console.ReadLine();
            Console.WriteLine("Id: ");
            zap.id = int.Parse(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Unesi mjesečnu plaću: ");
                a = Console.ReadLine().ToString();
                float t = float.Parse(a);
                if (t > 0)
                {
                    d[i] = t;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine(zap.id.ToString() + " " + zap.imePrezime);
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(d[i].ToString() + " ");
            }

            Console.WriteLine("Ukupno: " + zap.godisnjaZarada(d).ToString());
            Console.WriteLine("Prosjek: " + zap.prosjek(d).ToString());
            Console.ReadLine();
        }
    }
}
