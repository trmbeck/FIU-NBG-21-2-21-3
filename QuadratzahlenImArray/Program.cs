using System;

namespace QuadratzahlenImArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array füllen mit Quadratzahlen
            int[] quadratzahlen = new int[10];

            for (int i = 0; i < quadratzahlen.Length; i++)
            {
                quadratzahlen[i] = i * i;
            }

            // zahl >9    --> Hinweis
            // zahl == -1 --> Beenden der Schleife
            // zahl < -1  --> Hinweis
            do //Endlosschleife - fussgesteuert
            {
                Console.Write("Bitte Zahl eingeben (0-9): ");
                int basis = Convert.ToInt32(Console.ReadLine());
                if (basis >= 10 || basis < -1)
                {
                    Console.WriteLine("Die Zahl kann nicht ausgewertet werden, bitte eine gültige Zahl eingeben!");
                }
                else if(basis == -1)
                {
                        break; // beendet die Schleife
                }
                else
                {
                    Console.WriteLine($"das Quadrat von {basis} ist {quadratzahlen[basis]}");
                }
            } while (true);
        }
    }
}
