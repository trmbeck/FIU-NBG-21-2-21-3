using System;

namespace ErstesProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            // EVA --> Eingabe, Verarbeitung, Ausgabe            
            //Variablendeklaration
            int zahl1;
            int zahl2;
            string eingabe; //Typ string -> Zeichenfolge
            int ergebnis;
           
            //Eingabe
            Console.WriteLine("Bitte Zahl 1 eingeben: ");
            eingabe = Console.ReadLine();
            zahl1 = Convert.ToInt32(eingabe); //Zuweisung

            Console.WriteLine("Bitte Zahl 2 eingeben: ");
            eingabe = Console.ReadLine();
            zahl2 = Convert.ToInt32(eingabe);

            //Verarbeitung
            ergebnis = zahl1 + zahl2; // arithmetische Operation (Addition)

            //Console.WriteLine("zahl1");
            //Console.WriteLine(zahl1);

            //Ausgabe
            Console.WriteLine("Ergebnis:");
            Console.WriteLine(ergebnis);
        }
    }
}
