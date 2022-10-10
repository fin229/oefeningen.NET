using System;

namespace VraagExamen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam, invoer, puntenlijst = "";
            int aantalvakken = 4, punten = 0;
            double gemiddelde = 0, totaal = 0;

            do
            {
                Console.Write("Geef de naam van de student in: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(naam));

            for (int i = 1; i <= aantalvakken; i++)
            {
                do
                {
                    Console.Write("Geef het resultaat voor vak {0}", i);
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out punten) || punten < 0 || punten > 20);
                puntenlijst += $"Vak {i}: {punten}/20\n";
                totaal += punten;

            }
            gemiddelde += ((totaal / 4) / 20)*100;
            ;
            if (gemiddelde <50)
            {
                Console.WriteLine(naam);
                Console.WriteLine(new String('-', naam.Length), "\n");
                Console.WriteLine(puntenlijst, "\n");
                Console.WriteLine("Gemiddelde: {0}%\n", gemiddelde);
                Console.WriteLine("Helaas, je bent niet geslaagd...");
            }
            else if (gemiddelde < 70 || gemiddelde == 50)
            {
                Console.WriteLine(naam);
                Console.WriteLine(new String('-', naam.Length), "\n");
                Console.WriteLine(puntenlijst, "\n");
                Console.WriteLine("Gemiddelde: {0}%\n", gemiddelde);
                Console.WriteLine("Proficiat, je bent geslaagd!");
            }
            else if(gemiddelde >=70 )
            {
                Console.WriteLine(naam);
                Console.WriteLine(new String('-', naam.Length), "\n");
                Console.WriteLine(puntenlijst, "\n");
                Console.WriteLine("Gemiddelde: {0}%\n", gemiddelde);
                Console.WriteLine("Proficiat, je bent met onderscheiding geslaagd!");
            }



        }



    }
}

