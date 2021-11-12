﻿using System;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Bedingung = false;
            Bedingung = true;

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

            #endregion
        }
    }
}
