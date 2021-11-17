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

            //Regulärer String
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


            //Ein String ist ein Array von char
            char[] zeichenfolge = new char[10];
            string zeichenfolge2 = "1234567890";
            for (int i=0;i < zeichenfolge2.Length; i++)
            {
                Console.Write(zeichenfolge2[i]);
                //System.Threading.Thread.Sleep(1000); //eine Sekunde warten
            }

            //String Formatierung mit Platzhalter
            Console.WriteLine("\n\nString Formatierung\nSyntax: {index[,alignment][:FormatierungsString]}");
            string formatierterString = String.Format("Temperatur in C°: max {1} min {0}", 23.5, 34.2);
            Console.WriteLine(formatierterString);

            double[] maxTemp = new double[4] { 29.5,27.45,27.9,28.5};
            double[] minTemp = new double[4] { 19.9, 18.635424446, 19.2,19.4};


            Console.WriteLine("{0,5} {1,7} {2,7}","Tage","MinTemp","MaxTemp");
            Console.WriteLine("----------------------");
            for (int i = 0; i < 4; i++)
            {
                // alignment:   positiver Wert: rechtsbündig
                //              negativer Wert: linksbündig
                Console.WriteLine("{0,-6}{1,-8:F2}{2,-7}",i+1,minTemp[i],maxTemp[i]);
            }

            Console.WriteLine("{0:C2}",12.345);   // C -> Währung
            Console.WriteLine("{0:P0}",0.4);      // Prozent
            Console.WriteLine("{0} {0:X}",191);   // Hexadezimalzahl
            Console.WriteLine("{0} {0:E2}",1.5e3);// Exponentialschreibweise

            Console.WriteLine("{0:#####}",1234.5678);       // Ziffernplatzhalter
            Console.WriteLine("{0:00000}", 1234.5678);      // 0-Platzhalter
            Console.WriteLine("{0:#####.##}", 1234.5678);   // Dezimaltrennzeichen
            Console.WriteLine("{0:% #0.00}", 0.036);        //Prozentplatzhalter

            int zahl1 = 12;
            int zahl2 = 42;
            Console.WriteLine("Zahl1: {0} Zahl2: {1}",zahl1, zahl2);
            Console.WriteLine($"Zahl1: {zahl1} Zahl2: {zahl2}");
            Console.WriteLine($"Zahl1: {zahl1,4:c2} Zahl2: {zahl2,8:f4}");

        }
    }
}
