using System;

namespace Raumtemperatur2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 Tage lang soll die Temperatur von Räumen (5 Räume) gemessen werden.
            // 1. Dimension -> Tage
            // 2. Dimension -> Räume

            float[,] temperaturen = new float[3, 2];

            for (int indexTage = 0; indexTage < temperaturen.GetLength(0); indexTage++)
            {
                for (int indexRaeume = 0; indexRaeume < temperaturen.GetLength(1); indexRaeume++)
                {
                    Console.Write($"Bitte Temperatur für Tag {indexTage + 1} und Raum {indexRaeume + 1} angeben: ");
                    string eingabe = Console.ReadLine();
                    temperaturen[indexTage, indexRaeume] = Convert.ToSingle(eingabe);
                }
            }

            // Durchschnittstemperatur berechnen
            for (int iRaum = 0; iRaum < temperaturen.GetLength(1); iRaum++)
            {
                float summe = 0;
                for (int iTage = 0; iTage < temperaturen.GetLength(0); iTage++)
                {
                    summe += temperaturen[iTage, iRaum];
                }
                Console.WriteLine("Die Durchschnittstemperatur von Raum {0} beträgt {1:f2} C°",iRaum + 1,summe / temperaturen.GetLength(0));
            }
        }
    }
}
