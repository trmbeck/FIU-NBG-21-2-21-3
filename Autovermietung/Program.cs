using System;

namespace Autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autovermietung");
            Console.Write("Eingabe Kilometer: ");
            int km = Convert.ToInt32(Console.ReadLine());
            double betrag = 68;
            if (km > 200) betrag = 68 + (km - 200) * 0.65;
            Console.WriteLine("Rechnungsbetrag: " + ((int)((betrag * 1.19)*100+0.5)/100.0) + " Euro");
            Console.WriteLine("Rechnungsbetrag: {0:f4} Euro", betrag * 1.19);
            Console.WriteLine("Rechnungsbetrag: " + Math.Round(betrag * 1.19,3) + " Euro");
            Console.WriteLine("MwSt: {0:f2}", betrag * 0.19 );
        }
    }
}
