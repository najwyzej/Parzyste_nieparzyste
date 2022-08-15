using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczby_parzyste_i_nieparzyste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę:");
            var number = ParseNumber();
            if (number % 2 == 0)
                Console.WriteLine("Liczba jest parzysta.");
            else
                Console.WriteLine("Liczba jest nieparzysta.");

            Console.ReadLine();
        }
        private static int ParseNumber()
        {
            var number = 0;
            var correct = false;
            while(!correct)
            {
                correct = int.TryParse(Console.ReadLine(), out number);
                if (!correct)
                {
                    Console.WriteLine("Nieobsługiwany znak. Wpisz poprawną wartość.");
                }
            }
            return number;
        }
    }
}
