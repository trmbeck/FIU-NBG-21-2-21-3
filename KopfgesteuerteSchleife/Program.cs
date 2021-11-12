using System;

namespace KopfgesteuerteSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Es sollen die Zahlen 1 bis 10 ausgegeben werden
            int zahl = 1;
            while (zahl < 11)
            {
                Console.WriteLine(zahl);
                zahl = zahl + 1;
            }


            //Eingabe zurückgeben bis Abbruch eingeben wurde
            //>Hallo
            //Hallo
            //>Welt
            //Welt
            //>Abbruch
            string eingabe = "";
            while(eingabe != "Abbruch")
            {
                Console.Write(">");
                eingabe = Console.ReadLine();
                Console.WriteLine(eingabe);
            }

            Console.WriteLine("ENDE!");


        }
    }
}
