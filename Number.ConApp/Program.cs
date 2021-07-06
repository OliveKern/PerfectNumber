using System;

namespace Number.ConApp
{
    class Program
    {
#pragma warning disable IDE0060 // Nicht verwendete Parameter entfernen
        static void Main(string[] args)
#pragma warning restore IDE0060 // Nicht verwendete Parameter entfernen
        {
            Console.WriteLine("Number-App!");

            string input, output;
            long number;

            //Eingabe (E)
            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein!");
                input = Console.ReadLine();

            } while (long.TryParse(input, out number) == false);

            //Verarbeitung (V)
            if (Number.Logic.NumberProperty.IsPerfect(number))
            {
                output = $"{number} ist eine perfekte Zahl :-) ";
            }
            else
            {
                output = $"{number} ist keine perfekte Zahl :-( ";
            }


            //Ausgabe (A)
            Console.WriteLine(output);

            if (Number.Logic.NumberProperty.IsPrime(number))
            {
                output = $"{number} ist eine Primzahl :-) ";
            }
            else
            {
                output = $"{number} ist keine Primzahl :-( ";
            }

            Console.WriteLine(output);
        }
    }
}
