using System;

namespace FussgesteuerteSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            do
            {
                do
                {
                    //Console.Clear();
                    Console.WriteLine("1. IP-Adresse abrufen");
                    Console.WriteLine("2. Traceroute");
                    Console.WriteLine("3. Pathping");
                    Console.WriteLine("4. Beenden");
                    Console.Write("Auswahl: ");
                    string eingabe = Console.ReadLine();
                    auswahl = Convert.ToInt32(eingabe);

                } while (auswahl > 4);

                if (auswahl == 1)
                {
                    Console.WriteLine("ipconfig.exe");
                    System.Diagnostics.Process.Start("c:\\windows\\System32\\ipconfig.exe");
                }
                if (auswahl == 2) Console.WriteLine("tracert.exe");
                if (auswahl == 3) Console.WriteLine("pathping.exe");
            } while (auswahl != 4);
        }
    }
}
