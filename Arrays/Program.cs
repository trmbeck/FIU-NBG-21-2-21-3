using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Eindimensionale Arrays
            int[] punkteListe;          // Deklaration eines Arrays vom Typ int
            punkteListe = new int[5];   // Erzeugen von Heapspeicherreservierung für 3 int-Werte

            //punkteListe[0] = 92;        // Zuweisung von 92 zum erstem Element des Arrays (Index 0)
            //punkteListe[1] = 77;
            //punkteListe[2] = 87;

            int index = 2;
            //Zugriff auf Element 3 (index = 2)
            Console.WriteLine("Element mit Index " + index + " von PunkteListe: " + punkteListe[index]);

            int laengeDesArrays = punkteListe.Length; // Ruft die Anzahl der Elemente des Arrays ab
            Console.WriteLine("Länge des 'PunkteListe'-Arrays: " + laengeDesArrays);
            
            for (int i = 0; i < laengeDesArrays; i++)
            {
                Console.Write("Bitte Punktezahl für Test Nr. " + (i + 1) + ": ");
                punkteListe[i] = Convert.ToInt32(Console.ReadLine()); // variabler Zugriff auf Arrayelemente
            }

            double summe = 0;
            foreach(int item in punkteListe)
            {
                Console.WriteLine("Punkte: " + item);
                summe += item; // summe = summe + item;
            }
            Console.Write("Durchschnitt: " + (summe/punkteListe.Length));

            //2. Array
            double[] Durchschnittsliste = new double[10];

            //3. Array mit Arrayinitialisierer
            string[] Wochentage = new string[] { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" }; //Auflistung der Elemente mit Kommatrennung
            Console.WriteLine("Wochentag: " + Wochentage[3]);


            //Zusammenführen zweier Arrays
            int[] punkteListe2 = new int[4];
            int[] GesamtListe = new int[punkteListe.Length + punkteListe2.Length];
            
            for(int i =0; i < punkteListe.Length; i++)
            {
                GesamtListe[i] = punkteListe[i];
            }
            
            for(int i = punkteListe.Length; i < punkteListe.Length + punkteListe2.Length-1; i++)
            {
                GesamtListe[i] = punkteListe2[i];
            }

            //Array aufteilen
            int[] liste1 = new int[GesamtListe.Length / 2];
            int[] liste2 = new int[(GesamtListe.Length / 2)+(GesamtListe.Length % 2)];

            for (int i = 0; i < liste1.Length; i++)
            {
                liste1[i] = GesamtListe[i];
            }

            for (int i = liste1.Length; i < liste1.Length + liste2.Length; i++)
            {
                liste2[i] = GesamtListe[i];
            }
            #endregion


            ConsoleKeyInfo taste = Console.ReadKey();
            if (taste.Key == ConsoleKey.UpArrow) ;
        }
    }
}
