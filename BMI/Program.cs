using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Koerpergroeße in cm angeben");
            string eingabe = Console.ReadLine();
            double groesse = Convert.ToDouble(eingabe);

            groesse = groesse / 100;

            Console.WriteLine("Bitte Gewicht in kg angeben");
            eingabe = Console.ReadLine();
            double gewicht = Convert.ToDouble(eingabe);

            double bmi = BerechneBMI(gewicht,groesse);

            string auswwertung = AuswertungBMI(bmi);
            Console.WriteLine(auswwertung);

            double BerechneBMI(double GewichtInKg, double GroesseInMeter)
            {
                double BMI = GewichtInKg / (GroesseInMeter * GroesseInMeter);
                return BMI;
            }

            string AuswertungBMI(double BMI)
            {
                if (BMI < 18.5)
                {
                    return "Untergewicht";
                }else 
                if (BMI > 24.9) 
                {
                    return "Übergewicht";
                }
                else
                {
                    return "Normalgewicht";
                }
            }

        }
    }
}
