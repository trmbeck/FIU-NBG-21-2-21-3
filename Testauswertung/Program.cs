using System;

namespace Testauswertung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe der Punkte
            Console.Write("Bitte Punktzahl eingeben: ");
            int punktzahl = Convert.ToInt32(Console.ReadLine());
            //Aufruf der Methode pruefeTestpunktzahl
            string ergebnis = pruefeTestpunktzahl(punktzahl);
            if (ergebnis != "'nicht bestanden'" )
                Console.WriteLine($"Der Test ist mit der Note {ergebnis} bestand worden.");
            else
                Console.WriteLine($"Der Test ist {ergebnis}");

            string pruefeTestpunktzahl(int Punkte)
            {
                string note = "";
                switch (Punkte)
                {
                    case 10:
                        note = "'sehr gut'";
                        break;
                    case 9:
                        note = "'gut'";
                        break;
                    case 8:
                        note = "'befriedigend'";
                        break;
                    case 7:
                        note = "'ausreichend'";
                        break;
                    default:
                        note = "'nicht bestanden'";
                        break;
                }
                return note;
            }
        }
    }
}
