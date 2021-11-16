using System;

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.Write("Bitte Höhe eingeben: ");
                string eingabe = Console.ReadLine();
                int h = Convert.ToInt32(eingabe); // Bsp. 6

                for (int zeile = 0; zeile < h; zeile++)
                {
                    for (int spalte = zeile; spalte < h - 1; spalte++)
                    {
                        Console.Write(" ");
                    }
                    for (int zeichen = 0; zeichen < zeile * 2; zeichen++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 0; i < h - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
                
                
                string beenden;
                do
                {
                    Console.WriteLine("Wollen sie beenden?(y/n)");
                    beenden = Console.ReadLine();
                } while (beenden != "y" || beenden == "n");

                if (beenden == "y") break;
                //else Console.WriteLine("Wiedeholung");

            } while (true);
        }
    }
}
