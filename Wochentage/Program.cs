using System;

namespace Wochentage
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 - Sonntag
            // 1 - Montag
            // ...
            // 6 - Samstag

            int wochentag;
            do
            {

                Console.WriteLine("Geben Sie bitte eine Zahl von 0 bis 6 ein: ");
                wochentag = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Der Wochentag mit der Nummer {wochentag} ist ein ");
                switch (wochentag)
                {
                    case 0:
                        Console.WriteLine("Sonntag");
                        break;
                    case 1:
                        Console.WriteLine("Montag");
                        break;
                    case 2:
                        Console.WriteLine("Dienstag");
                        break;
                    case 3:
                        Console.WriteLine("Mittwoch");
                        break;
                    case 4:
                        Console.WriteLine("Donnertag");
                        break;
                    case 5:
                        Console.WriteLine("Freitag");
                        break;
                    case 6:
                        Console.WriteLine("Samstag");
                        break;
                    default:
                        Console.WriteLine("\b\b\b\b\b\b\b\b existiert nicht");
                        break;
                }
                Console.WriteLine("\n\n");
            } while (true);
        }
    }
}
