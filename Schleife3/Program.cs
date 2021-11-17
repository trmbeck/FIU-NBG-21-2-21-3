using System;

namespace Schleife3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hochzählen und runterzählen in einer Schleife");

            // 1,2,3,4,5,6,7,8,9,10,9,8,7,6,5,4,3,2,1

            int inkrement = +1;
            Console.Write("\n\nAusgabe: ");
            for (int i = 1; i > 0; i = i + inkrement)
            {
                //if (i == 0) break;
                if (i == 1 && inkrement == -1)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i},");
                }
                if (i == 10) inkrement = -1;
            }
            //Console.WriteLine("\b ");
            Console.ReadKey();
        }
    }
}
