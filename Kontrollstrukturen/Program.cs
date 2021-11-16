using System;
using System.Threading;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Bedingung = false;
            //Bedingung = true;

            #region Verzweigung


            //einseitige Auswahl (Projekt volljährig)
            if (Bedingung)
            {
                //Anweisungen im Falle von wahrer Bedingung ...
            } // Überspringen im Falle von unwahrer Bedingung!

            //zweiseitige Auswahl
            if (Bedingung)
            {
                // true ...
            }
            else
            {
                //false
            }

            //mehrseitige Auswahl
            if (Bedingung)
            {

            }
            else
            {
                if (Bedingung)
                {

                }
                else
                {

                }
            }
            #endregion

            #region Schleifen

            /*
              Kopfgesteuerte Schleife
            
              ...
              Anweisungen

           +-> +------------------------+
           |   |  Schleifensteuerung    |  --+
           |   |       (Bedingung)      |    |
           |   +------------------------+    |
           |   |                        |    |
           |   |                        |    |
           |   | Schleifenrumpf         |    |  möglich, dass Rumpf nicht 1 mal ausgeführt wird
           |   |                        |    |
           |   |                        |    |
           +-  +------------------------+    |
                                             |
              Anweisungen                <---+
              ...
              
             */

            //Schleifensteuerung
            while (Bedingung) //true -> Schleifenrumpf oder false -> Abbruch
            { //Anweisungsblock
                //Schleifenrumpf
                //Anweisung/en
            }


            //Fußgesteuerte Schleife
            /*
                ...
                Anweisungen
             
             +-> +------------------------+
             |   |                        |
             |   |                        |
             |   | Schleifenrumpf         |   mindestens 1 mal
             |   |                        |
             |   |                        |
             |   +------------------------+
             |   |  Schleifensteuerung    |
             |   |       (Bedingung)      |
             +-  +------------------------+
                            |
                            |
                            V
                Anweisungen                
                ...
             */

            do
            {//Schleifenrumpf
                //Anweisungen
            }
            while (Bedingung);



            //Zählergesteuerte Schleife
            int startwert = 1;
            int zähler;
            int endwert = 10;
            int schrittweite = 1;
            int abbruch = (new Random((int)DateTime.Now.Ticks)).Next(1,11); //Zufallszahl generieren
            
            // zähle von startwert bis endwert mit schrittweite
            // for(     startwert/zähler;   bedingung(endwert)   ;   erhöhen des zählers    )
            for (zähler = startwert; zähler <= endwert; zähler = zähler + schrittweite)
            {
                if (zähler == 5)
                {
                    Console.WriteLine("Zählerwert: fünf");
                    continue; //springt direkt zur Bedingungsprüfung bzw. Zähleränderung
                }
                Console.WriteLine("Zählerwert: " + zähler);
                
                if (zähler == abbruch) break; //beendet die Schleife sofort!
            }



            // Sammlungen iterieren
            // foreach-Schleife
            int[] zahlen = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for(int index = 0; index < zahlen.Length; index++)
            {
                int item = zahlen[index];
                Console.WriteLine(item);
            }

            foreach(int item in zahlen)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("ENDE!");
            #endregion
        }
    }
}
