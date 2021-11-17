using System;

namespace StaedtePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] staedte = { "Berlin", "Hamburg", "München", "Köln", "Frankfurt a. M." };
            DateTime[] jahr1 =
            {
                new DateTime(1950,1,1),
                new DateTime(1950,1,1),
                new DateTime(1950,1,1),
                new DateTime(1950,1,1),
                new DateTime(1950,1,1)
            };
            int[] population1 =
            {
                3336026,1605606,831937,594941,532037
            };
            DateTime[] jahr2 =
            {
                new DateTime(2020,1,1),
                new DateTime(2020,1,1),
                new DateTime(2020,1,1),
                new DateTime(2020,1,1),
                new DateTime(2020,1,1)
            };
            int[] population2 =
            {
                3664088,1852478,1488202,1083498,764104
            };


            // Stadt     Jahr   Population   Jahr   Population  Änderung (%)

            string kopfzeile = String.Format(
                $"{"Stadt",-15}{"Jahr",8}{"Population",12}{"Jahr",8}{"Population",12}{"Änderung(%)",14}");
            kopfzeile = String.Format(
                "{0,-15}{1,8}{2,12}{1,8}{2,12}{3,14}", "Stadt", "Jahr", "Population", "Änderung(%)");

            Console.WriteLine(kopfzeile);
            Console.WriteLine();

            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine($"{staedte[i],-15}{jahr1[i],8:yyyy}{population1[i],12:N0}{jahr2[i],8:yyyy}{population2[i],12:N0}{1 - population1[i] / (double)population2[i],14:P1}");
            }
        }
    }
}
