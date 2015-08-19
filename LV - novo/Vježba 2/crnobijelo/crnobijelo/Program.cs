using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crnobijelo
{
    class rijec
    {
        public string word;
        public int BrojPonavljanja;

        public void ispis(string word, int BrojPonavljanja)
        {
            for (int i = 0; i < BrojPonavljanja; i++)
                Console.WriteLine(word);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rijec r1, r2, r3;
            r1=new rijec();
            r2 = new rijec();
            r3 = new rijec();
            char jos = 'D';
            do
            {
                Console.WriteLine("Unesite boju: ");
                r1.word = Console.ReadLine();
                Console.WriteLine("Unesite broj ponavljanja: ");
                r2.BrojPonavljanja = int.Parse(Console.ReadLine());
                r3.ispis(r1.word, r2.BrojPonavljanja);
                Console.WriteLine("---------------------------");
                Console.WriteLine("Zelite li jos ispis (D): ");
                string pomocni = Console.ReadLine();
                jos = char.Parse(pomocni);
            } while (jos == 'D');
            Console.WriteLine("KRAJ!");
            Console.ReadLine();
        }
    }
}
