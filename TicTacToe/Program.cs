using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            /*
            +---+---+---+
            | 1 | 2 | O |
            +---+---+---+
            | 4 | X | 6 | 
            +---+---+---+
            | 7 | 8 | 9 |
            +---+---+---+
            */
           
            char spieler = 'O';
            do
            {
                char[] steine = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                string sieger = "";
                int durchgang = 0;
                do
                {
                    char wahl;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("+---+---+---+");
                        Console.WriteLine($"| {steine[0]} | {steine[1]} | {steine[2]} |");
                        Console.WriteLine("+---+---+---+");
                        Console.WriteLine($"| {steine[3]} | {steine[4]} | {steine[5]} |");
                        Console.WriteLine("+---+---+---+");
                        Console.WriteLine($"| {steine[6]} | {steine[7]} | {steine[8]} |");
                        Console.WriteLine("+---+---+---+");
                        Console.WriteLine("\nBitte wählen, Spieler " + spieler);
                        wahl = Convert.ToChar(Console.ReadLine());
                        //Eingabe prüfen wahl ist char und kann mit ASCII-Wert verglichen werden
                    } while (wahl < 49 || wahl > 57 || steine[wahl - 49] == 'X' || steine[wahl - 49] == 'O');

                    //Spielstein setzen
                    steine[wahl - 49] = spieler;
                    durchgang++;

                    //Gewinnauswertung
                    string player = string.Concat(spieler, spieler, spieler); // player = "XXX" oder "OOO"

                    //in reihen
                    for (int i = 0; i < 9; i += 3)
                    {
                        string reihe = string.Concat(steine[i], steine[i + 1], steine[i + 2]);
                        if (reihe == player) sieger = player;
                    }

                    //in spalten
                    for (int i = 0; i < 3; i++)
                    {
                        string spalte = string.Concat(steine[i], steine[i + 3], steine[i + 6]);
                        if (spalte == player) sieger = player;
                    }

                    //in Diagonalen
                    if (string.Concat(steine[0], steine[4], steine[8]) == player) sieger = player;
                    if (string.Concat(steine[2], steine[4], steine[6]) == player) sieger = player;

                    // spieler wechseln
                    spieler = spieler == 'O' ? 'X' : 'O';

                    //Alle Steine gesetzt?
                    if (durchgang == 9 && sieger == "") sieger = "Unentschieden";
                } while (sieger == "");

                Console.Clear();
                Console.WriteLine("+---+---+---+");
                Console.WriteLine($"| {steine[0]} | {steine[1]} | {steine[2]} |");
                Console.WriteLine("+---+---+---+");
                Console.WriteLine($"| {steine[3]} | {steine[4]} | {steine[5]} |");
                Console.WriteLine("+---+---+---+");
                Console.WriteLine($"| {steine[6]} | {steine[7]} | {steine[8]} |");
                Console.WriteLine("+---+---+---+");

                if (sieger == "Unentschieden")
                    Console.WriteLine("\nKein Sieger!!!");
                else
                    Console.WriteLine("\nSieger ist Spieler " + sieger[0]);

                Console.WriteLine("nochmal (J/N)?");
            } while (Console.ReadLine().ToUpper() == "J");

        }
    }
}
