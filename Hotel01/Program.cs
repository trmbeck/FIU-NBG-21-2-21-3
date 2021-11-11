using System;

namespace Hotel01
{
    class Program
    {
        static void Main(string[] args)
        {
            int AnzahlPersonen;
            int Aufenthaltsdauer;


            decimal Zimmerpreis = 70;
            decimal MwStSatz = 0.19M;
            decimal MwSt;
            decimal Gesamtpreis;
            decimal Nettopreis;

        Anfang:
            Console.Clear();
            Console.Write("Anzahl der Personen: ");
            string eingabe = Console.ReadLine();
            AnzahlPersonen = Convert.ToInt32(eingabe);
            Console.WriteLine("Anzahl der Personen ist: " + AnzahlPersonen);
            Console.WriteLine();

            Console.Write("Aufenthaltsdauer: ");
            Aufenthaltsdauer = Convert.ToInt32(Console.ReadLine());
            //Aufenthaltsdauer beträgt 1 Tag
            if (Aufenthaltsdauer == 1)
                Console.WriteLine("Aufenthaltsdauer beträgt 1 Tag");
            else
                Console.WriteLine("Aufenthaltsdauer beträgt " + Aufenthaltsdauer + " Tage");
            //Aufenthaltsdauer beträgt 2 Tage
            Console.WriteLine();

            Nettopreis = Zimmerpreis * Aufenthaltsdauer * AnzahlPersonen;
            MwSt = Nettopreis * MwStSatz;
            Gesamtpreis = Nettopreis + MwSt;

            string ausgabe = "Der Gesamtpreis beträgt " + Gesamtpreis + " Euro.\n\nVielen Dank.";
            Console.WriteLine(ausgabe);

            Console.WriteLine("Bitte Taste drücken ... (ESC zum Beenden)");
            if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            goto Anfang; // goto ist böse :)
        }
    }
}
