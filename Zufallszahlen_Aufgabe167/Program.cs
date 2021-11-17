using System;

namespace Zufallszahlen_Aufgabe167
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] zahlen = new byte[6];
            Random Zufall = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < zahlen.Length; i++)
            {
                byte zufallszahl;
                bool Kollision;

                Kollision = false;
                zufallszahl = (byte)Zufall.Next(1, 45);
                //Console.Write(zufallszahl + ", ");
                foreach (byte item in zahlen)
                {
                    if (item == zufallszahl)
                    {
                        Kollision = true;
                        i--;
                    }
                }

                if (Kollision == false) 
                    zahlen[i] = zufallszahl;
            }
            Console.WriteLine();

            foreach (byte item in zahlen)
            {
                Console.WriteLine(item);
            }
        }
    }
}
