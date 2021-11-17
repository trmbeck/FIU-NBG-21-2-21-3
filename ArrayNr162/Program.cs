using System;

namespace ArrayNr162
{
    class Program
    {
        static void Main(string[] args)
        {
            //erste Möglichkeit der Initialisierung
            int[] meinArray1 = new int[5];
            meinArray1[0] = 1;
            meinArray1[1] = 2;
            meinArray1[2] = 3;
            meinArray1[3] = 4;
            meinArray1[4] = 5;

            //zweite Möglichkeit der Initialisierung
            int[] meinArray2 = { 1, 2, 3, 4, 5 };

            //dritte Möglichkeit der Initialisierung - Aufgabe Nr. 164
            int[] meinArray3 = new int[10];
            for (int i = 50; i <= 59; i = i + 1)
            {
                meinArray3[i-50] = i;
            }

            //Ausgabe
            foreach (int item in meinArray1)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();

            foreach (int item in meinArray3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
