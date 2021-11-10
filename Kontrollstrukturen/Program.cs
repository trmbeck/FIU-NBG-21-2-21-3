using System;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Bedingung = false;
            Bedingung = true;

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
        }
    }
}
