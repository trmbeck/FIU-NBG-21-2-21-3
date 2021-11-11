using System;

namespace Zeichenfolgen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escape-Sequenzen
            string escape = "Hallo\nWelt!\b?\rFIU\t\t1000"; // Backslash leitet die Escape-Sequenz ein

            Console.WriteLine(escape);
            Console.WriteLine("€");
            // Dateipfad:
            // c:\users\admin\documents
            string path = "c:\\users\\admin\\documents";
            Console.WriteLine(path);

            // Ausgabe: Hallo "FIU"
            string FIU = "Hallo \"FIU\"";
            Console.WriteLine(FIU);

            string Welt = "Hallo 'Welt'";
            Console.WriteLine(Welt);

            string w = "'W'";
            char c = '\'';

            Console.WriteLine(w);
            Console.WriteLine(c);

            /*
             Zeichenfolgen-Escapesequenzen
                ZEICHENFOLGEN-ESCAPESEQUENZEN
                Escapesequenz	Zeichenname	                    Unicode-Codierung
                \'	            Einfaches Anführungszeichen	    0x0027
                \"	            Doppeltes Anführungszeichen	    0x0022
                \\	            Umgekehrter Schrägstrich	    0x005C
                \0	            Null	                        0x0000
                \a	            Warnung	                        0x0007
                \b	            Rückschritt	                    0x0008
                \f	            Seitenvorschub	                0x000C
                \n	            Zeilenwechsel	                0x000A
                \r	            Wagenrücklauf	                0x000D
                \t	            Horizontaler Tabulator	        0x0009
                \v	            Vertikaler Tabulator	        0x000B
                \u	            Unicode-Escapesequenz (UTF-16)	\uHHHH (Bereich: 0000 - FFFF; Beispiel: \u00E7 = "ç")
                \U	            Unicode-Escapesequenz (UTF-32)	\U00HHHHHH (Bereich: 000000 - 10FFFF; Beispiel: \U0001F47D = "👽")
                \x	            Unicode-Escapesequenz, die ähnlich wie "\u" ist, außer mit variabler Länge	\xH[H][H][H] (Bereich: 0 - FFFF; Beispiel: \x00E7 or \x0E7 oder \xE7 = "ç")
             */

            // UNC-PFad: \\server\freigabe\datei.xy
            string UNCpfad = "\\\\server\\freigabe\\datei.xy";
            Console.WriteLine(UNCpfad);

            // Verbatim Stringzeichen @
            string verbatimString = @"\\server\freigabe\datei.xy"; 
            Console.WriteLine(verbatimString);

            // Zusammenfügen von Zeichenfolgen (Konkatenation)
            string a = "Hallo ";
            string b = "Welt";

            int zahl = 10;
            string zusammen = a + b + "!" + "\n" + "wie geht's" + '?' + zahl; // Konkatenation über + operator
            Console.WriteLine(zusammen);
            string con = String.Concat(a, b, "!", "\n","wie geht's",'?', zahl); // gleiche wie zuvor nur über den "Befehl" String.Concat
            Console.WriteLine(con);

        }
    }
}
