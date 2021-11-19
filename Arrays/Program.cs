using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto jagged;
            #region Eindimensionale Arrays Kapitel 11

            int[] punkteListe;          // Deklaration eines Arrays vom Typ int
            punkteListe = new int[5];   // Erzeugen von Heapspeicherreservierung für 3 int-Werte

            //punkteListe[0] = 92;        // Zuweisung von 92 zum erstem Element des Arrays (Index 0)
            //punkteListe[1] = 77;
            //punkteListe[2] = 87;
            //punkteListe[3] = 21;
            //punkteListe[4] = 123;

            /*
             
              punkteliste
            +-----+-----+-----+-----+-----+
            |  0  |  1  |  2  |  3  |  4  | Index
            +-----+-----+-----+-----+-----+
            |  92 |  77 |  87 |  21 | 123 | Werte
            +-----+-----+-----+-----+-----+

            */

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
            int[] GesamtListe = new int[punkteListe.Length + punkteListe2.Length]; //5+4
            
            for(int i =0; i < punkteListe.Length; i++)
            {
                GesamtListe[i] = punkteListe[i];
            }
            
            for(int i = punkteListe.Length; i < punkteListe.Length + punkteListe2.Length-1; i++)
            {
                GesamtListe[i] = punkteListe2[i];
            }

            //integrierte Kopierfunktion
            Array.Copy(punkteListe, 0, GesamtListe, 0, punkteListe.Length);
            Array.Copy(punkteListe2, 0, GesamtListe, punkteListe.Length, punkteListe2.Length);

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

            #region mehrdimensionale Arrays bis max. 32 Dimensionen Kapitel 11.2

            //2D-Arrays
            int[,] array2D;
            array2D = new int[3,12]; // "Tabelle" mit 3 Zeilen (rows) und 12 Spalten (columns)
            array2D[1, 6] = 4;
            array2D[2, 2] = 8;

            /*
                0   1   2
              +---+---+---+
           0  | 1 | 2 | O |
              +---+---+---+
           1  | 4 | X | 6 | 
              +---+---+---+
           2  | 7 | 8 | 9 |
              +---+---+---+
           */

            char[,] tictactoe = new char[,]
            {
                { '1' , '2' , '3' },
                { '4' , '5' , '6' },
                { '7' , '8' , '9' }
            };
            tictactoe[0, 1] = 'X';


            //3D-Array
            int[,,] array3D = new int[2, 3, 4];

            //8D-Array
            int[,,,,,,,] array8D = new int[5, 3, 5, 6, 87, 5, 3, 4];

            // Eigenschaften von Arrays
            Console.WriteLine("Dimensionen: {0}",array8D.Rank);
            Console.WriteLine("Anzahl Elemente des gesamten Arrays: " + array8D.Length);
            
            Console.WriteLine("Max Index der Dimension 1: {0}", array8D.GetUpperBound(0));
            Console.WriteLine("Max Index der Dimension 2: {0}", array8D.GetUpperBound(1));
            Console.WriteLine("Max Index der Dimension 3: {0}", array8D.GetUpperBound(2));
            Console.WriteLine("Max Index der Dimension 4: {0}", array8D.GetUpperBound(3));
            Console.WriteLine("Max Index der Dimension 5: {0}", array8D.GetUpperBound(4));
            Console.WriteLine("Max Index der Dimension 6: {0}", array8D.GetUpperBound(5));
            Console.WriteLine("Max Index der Dimension 7: {0}", array8D.GetUpperBound(6));
            Console.WriteLine("Max Index der Dimension 8: {0}", array8D.GetUpperBound(7));

            Console.WriteLine("Länge der 5. Dimension: " + array8D.GetLength(4));

            // 1D-Arrays sortieren und umkehren
            System.Array.Sort(punkteListe);
            System.Array.Reverse(punkteListe);

            System.Array.Clear(punkteListe,1,2); //zurücksetzen der Werte von punkteliste beginnend bei index 1 und 2 Elemente weit

            #endregion

            jagged:
            #region Verzweigte (jagged) Arrays Kapitel 11.3

            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 23,74,56,14 };
            jaggedArray[1] = new int[] { 17,38,21 };
            
            Console.WriteLine("Wert 38 ist abrufbar mit jaggedArray[1][1] --> " + jaggedArray[1][1]);

            string[][] jaggedStringArray = new string[3][];


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

            foreach (int[] array in jaggedArray)
            {
                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }
            }

            #endregion
        }
    }
}
