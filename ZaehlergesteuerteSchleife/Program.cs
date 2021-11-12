using System;

namespace ZaehlergesteuerteSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ausgabe;
            +----------------------+
            |                      |
            |                      |
            |                      |
            |                      |
            |                      |
            |                      |
            +----------------------+
            */
            int zähler;
            int zähler2;
            int breite = Convert.ToInt32(Console.ReadLine());
            int zeilenanzahl = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("+");
            for(zähler = 1; zähler < breite; zähler = zähler + 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            //zeilenanzahl = 10;
            for(zähler = 1; zähler < zeilenanzahl; zähler = zähler + 1)
            {
                Console.Write("|");
                for(zähler2 = 1; zähler2 < breite; zähler2 = zähler2 + 1)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }


            Console.Write("+");
            for (zähler = 1; zähler < breite; zähler = zähler + 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

        }
    }
}
