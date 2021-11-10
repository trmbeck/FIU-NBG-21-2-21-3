using System;

namespace Volljährig
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kontrollstrukturen
            //Verzweigung
            /*
             Einseitige Auswahl
             */

            // Eingabe Alter
            // Prüfung auf Volljährigkeit
            // Ausgabe volljährig, wenn es zutrifft

            int alter;
            Console.WriteLine("Bitte Alter eingeben: ");
            string eingabeAlter = Console.ReadLine();
            alter = Convert.ToInt32(eingabeAlter);

            Console.WriteLine("\n\neinseitige Auswahl:\n------------------");

            if (alter > 17)
            {
                Console.WriteLine("Sie sind " + alter); //Konkatenation
                Console.WriteLine("Sie sind volljährig!");
            }
            if(alter < 18)
            {
                Console.WriteLine("Sie sind minderjährig!!");
            }

            /*
                zweiseitige Auswahl
            */

            Console.WriteLine("\n\nzweiseitige Auswahl\n---------------------");
            if(alter > 17)
                Console.WriteLine("Volljährig");
            else
                Console.WriteLine("Minderjährig");


            //mehrseitige Auswahl
            Console.WriteLine("\n\nmehrseitige Auswahl\n---------------------");
            if (alter > 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ab 18");
            }
            else
            {
                if (alter > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("ab 16");
                }
                else
                {
                    if (alter > 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ab 12");
                    }
                    else
                    {
                        Console.WriteLine("jünger als 12");
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ende!");
        }
    }
}
