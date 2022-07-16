using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę, a ja sprawdzę czy jest parzysta czy nieparzysta.");

            while(true)
            { 
            Console.WriteLine("Podaj liczbę:");
            var userNumber = GetNumber();

            if (userNumber % 2 == 0)
                Console.WriteLine("Liczba jest parzysta.");
            else
                Console.WriteLine("Liczba jest nieparzysta.");

            Console.WriteLine("Jeśli chcesz sprawdzić kolejne liczby to podaj liczbę, a jeśli chcesz wyjść z aplikacji wpisz 'x'.");
            }
        }

        private static int GetNumber()
        {
            while(true)
            {
                var userChoice = Console.ReadLine();

                if(userChoice.ToUpper() == "X")
                {
                    Environment.Exit(0);
                }

                if(!int.TryParse(userChoice, out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane! Spróbuj ponownie.");
                    continue;
                }
                return number;
            }
        }
    }
}
