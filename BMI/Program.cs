using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Koerpergroeße in CM angeben");
            string eingabe = Console.ReadLine();
            double groesse = Convert.ToDouble(eingabe);

            groesse = groesse / 100;

            Console.WriteLine("Bitte Gewicht in KG angeben");
            eingabe = Console.ReadLine();
            double gewicht = Convert.ToDouble(eingabe);

            double bmi = gewicht / (groesse * groesse);

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Untergewicht");
            }
            else if (bmi > 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Uebergewicht");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Normalgewicht");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
