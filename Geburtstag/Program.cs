using System;

namespace Geburtstag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Geburtstag eingeben: ");
            string eingabe = Console.ReadLine(); // 1.1.2001
            DateTime geb = Convert.ToDateTime(eingabe);
            Console.WriteLine("Geburtstag: " + geb.DayOfWeek);
        }
    }
}
