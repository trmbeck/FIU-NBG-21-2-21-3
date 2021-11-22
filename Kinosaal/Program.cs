using System;

namespace Kinosaal
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxReihe = 4;
            int maxSitze = 4;
            string[,] saal = new string[maxReihe, maxSitze];
            string eingabeAktion;
            Console.ForegroundColor = ConsoleColor.White;

            //Initialisierung der Sitze mit "F"
            for (int indexReihe = 0; indexReihe < maxReihe; indexReihe++)
            {
                for(int indexSitze = 0; indexSitze < maxSitze; indexSitze++)
                {
                    saal[indexReihe, indexSitze] = "F";
                }
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Kinosaal");
                Console.WriteLine("{0,3}{1,2}{2,2}{3,2}", 1, 2, 3, 4);
                for (int indexReihe = 0; indexReihe < maxReihe; indexReihe++)
                {
                    Console.Write(indexReihe + 1);
                    for (int indexSitze = 0; indexSitze < maxSitze; indexSitze++)
                    {
                        Console.Write("|");
                        // F - grün
                        // B - rot
                        // R - blau
                        Console.ForegroundColor = saal[indexReihe, indexSitze] == "B" ? ConsoleColor.Red : ConsoleColor.Blue;
                        if (saal[indexReihe, indexSitze] == "F") Console.ForegroundColor = ConsoleColor.Green;
                        
                        Console.Write(saal[indexReihe, indexSitze]);
                        
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("Bitte wählen - (B)elegen, (R)eservieren und (S)tonieren:");
                eingabeAktion = Console.ReadLine();
                int reihe;
                int sitz;
                if (eingabeAktion.ToUpper() == "E")
                {
                    //Schleifebedingung direkt prüfen !!!
                    continue;
                }
                else
                {
                    // Reihe und Sitz abfragen
                    Console.Write("Reihe: ");
                    reihe = Convert.ToInt32(Console.ReadLine())-1;

                    Console.Write("Sitz: ");
                    sitz = Convert.ToInt32(Console.ReadLine())-1;
                }

                if (eingabeAktion.ToUpper() == "B" || eingabeAktion.ToUpper() == "R" || eingabeAktion.ToUpper() == "S")
                    saal[reihe, sitz] = eingabeAktion.ToUpper() == "S" ? "F" : eingabeAktion.ToUpper();

                ////Alternative mit Fallauswahl
                //switch (eingabeAktion)
                //{
                //    case "B":
                //    case "b":
                //        saal[reihe, sitz] = "B";
                //        break;
                //    case "S":
                //    case "s":
                //        saal[reihe, sitz] = "F";
                //        break;
                //    case "R":
                //    case "r":
                //        saal[reihe, sitz] = "R";
                //        break;
                //}

                //// Exkurison
                //// speichern im Dateisystem
                //// System.IO Namespace
                //System.IO.File.WriteAllText(@"c:\users\meinProfilname\documents\saal.txt", saal.ToString());
                //string meineDatei = System.IO.File.ReadAllText(@"c:\users\meinProfilname\documents\saal.txt");

            } while (eingabeAktion.ToUpper() != "E");
        }
    }
}
