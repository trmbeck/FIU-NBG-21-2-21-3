using System;

namespace Prozeduren_Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 10;
            int zahl2 = 20;
            string eingabe;

            Console.WriteLine("Willkommen bei der Demo für Prozeduren!!!");
            do
            {
                MenueAusgeben(titel: "Grundrechenarten"); // Unterprogramm (Prozedur/Aktion)aufrufen
                
                Console.Write("Eingabe: ");
                eingabe = Console.ReadLine();
            } while (
                eingabe != "1"
                && 
                eingabe != "2"
                && 
                eingabe != "3"
                && 
                eingabe != "4"
                &&
                eingabe != "5"
                &&
                eingabe != "6"
                ); // true --> wiederholen

            switch (eingabe)
            {
                case "1":
                    Addition(zahl1,zahl2); //Prozeduraufruf mit zwei Argumenten (zahl1 und zahl2)
                    break;
                case "2":
                    int ergebnis = Subtraktion(zahl1, zahl2);
                    Console.WriteLine("Differnez: " + ergebnis);
                    break;
                case "3":
                    Console.WriteLine(zahl1 * zahl2);
                    break;
                case "4":
                    Console.WriteLine(zahl1 / zahl2);
                    break;
                case "5":
                    Quadrieren(zahl1); //Prozeduraufruf mit einem Argument (zahl1)
                    break;
                case "6":
                    PrimzahlenBis50Ausgeben(); //Prozeduraufruf mit keinem Argument
                    break;
            }
            Console.WriteLine("Ende");


            //Prozedurendeklarationen, in C# Methode, in UML Operation
            // Signatur (erste Zeile einer Methode - Deklaration)
            //
            // <Rückgabetyp> <Bezeichner>([<Parameter1>[,<Parameter2>[,<ParameterN>]]])
            // {
            //   Methodenrumpf
            // }
            //
            // Rückgabetyp: void -> kein Ergebnis
            // 

            void MenueAusgeben(string titel)
            {
                // Inhalt der Prozedur
                Console.Clear();
                Console.WriteLine(titel);
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraktion");
                Console.WriteLine("3) Multiplikation");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Quadrieren");
                Console.WriteLine("6) Primzahlen ausgeben");
                Console.WriteLine("Bitte wählen");
            }

            void Addition(int wert1,int wert2)
            {
                int summe;
                summe = wert1 + wert2;
                Console.WriteLine("Summe: {0}", summe);
            }

            void Quadrieren(int wert)
            {
                Console.WriteLine("Quadrat: {0}", wert * wert);
            }

            void PrimzahlenBis50Ausgeben()
            {
                Console.WriteLine("Ausgabe der Primzahlen bis 50:");
                Console.WriteLine("2,3,5,7,11,13,17,19,23,29,31,37,41,43,47");
                //return;
            }

            // Funktiondeklaration, in C# Methode, in UML Operation
            // Rückgabetyp ist ungleich void!!!
            int Subtraktion(int wert1, int wert2)
            {
                int Differenz;
                Differenz = wert1 - wert2;
                return Differenz;
            }

        }
    }
}
