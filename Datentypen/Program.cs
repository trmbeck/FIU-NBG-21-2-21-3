using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Datentypen\n-----------------");

            //Ganzzahlen
            sbyte GanzzahlSByte;    // 8 Bit  --> 2^8  --> -128 bis + 127
            short GanzzahlShort;    // 16 Bit --> 2^16 --> -32,768 bis 32,767
            int   GanzzahlInt;      // 32 Bit --> 2^32 --> -2,147,483,648 bis 2,147,483,647
            long  GanzzahlLong;     // 64 Bit --> 2^64 --> -9,223,372,036,854,775,808 bis 9,223,372,036,854,775,807

            GanzzahlInt = 1;
            GanzzahlInt = -10;
            //GanzzahlInt = 3000000000; // passt nicht in Datentyp rein!

            byte GanzzahlByte;      // 8 Bit  --> 2^8  --> 0 bis 255
            ushort GanzzahlUShort;  // 16 Bit --> 2^16 --> 0 bis 65535 unsigned
            uint GanzzahlUint;      // 32 Bit --> 2^32 --> 0 bis 4.294.967.295
            ulong GanzzahlULong;    // 64 Bit --> 2^64 --> 0 bis 18.446.744.073.709.551.615

            GanzzahlUint = 3000000000;

            /*
            128 64 32 16  8  4  2  1
           --------------------------
              0  0  1  1  1  0  1  0 --> 66 dez.
invertieren   1  1  0  0  0  1  0  1 --> Einer Komplement
addiere 1     1  1  0  0  0  1  1  0 --> Zweier Komplement --> -66 dez.

              0  0  0  0  0  1  0  0 --> 4 dez.
invertieren   1  1  1  1  1  0  1  1 --> Einer Komplement
addiere 1     1  1  1  1  1  1  0  0 --> Zweier Komplement --> -4 dez.

              -4 + 6 = +2

              1  1  1  1  1  1  0  0  
           +  0  0  0  0  0  1  1  0
             ------------------------
              0  0  0  0  0  0  1  0 --> dezimal 2

            */


            //Kommazahlen
            float KommaFloat;       //  4-Bytes einfache Genauigkeit: ~7 und 8 Stellen --> 0,333333      Datentyp im .NET Framework ist Single
            double KommaDouble;     //  8-Bytes doppelte Genauigkeit: ~15 bis 17 Stellen --> 0,33333333333333
            decimal KommaDecimal;   // 16-Bytes          Genauigkeit: ~28 bis 29 Stellen --> 0,333333333333333333333333333


            //Zeichen und Zeichenfolgen
            string Zeichenfolge;    // UTF-16 codierter Text, bis zu 2 GB (ca. 1 Mrd. Zeichen)
            char Character;         // UTF-16 codiertes Zeichen --> 2-Byte


            //boolscher Datentyp
            bool Bool;              // 1 Byte, Werte: true oder false

            //Casting und Literale
            KommaDouble = 10;           // 10 ist ein int-Literal (implizit gecastet)
            KommaDouble = 10.01;        // 10.01 ist ein double-Literal
            GanzzahlInt = (int)10.01;   // 10.01 ist ein double-Literal und wird gecastet
            GanzzahlInt = (int)KommaDouble; // explizites (Casting) = Umwandeln eines Datentyps in einen anderen
            KommaFloat = 10.01F;        // Literal-Suffix F für float
            GanzzahlLong = 29L;         // Literal-Suffix L für long

            Zeichenfolge = "Hallo FIU"; // Literal-Suffix für strings ist das doppelte Anführungszeichen
            Character = 'A';            // Literal-Suffix für chars ist das einfache Anführungszeichen

            Bool = true; Bool = false;  // Zuweisung von true und false




            // Min und Max Werte ausgeben
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("short");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + Int16.MinValue + "\n" +
            "Max: " + Int16.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("int");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + int.MinValue + "\n" +
            "Max: " + int.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("long");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + Int64.MinValue + "\n" +
            "Max: " + Int64.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("sbyte");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + sbyte.MinValue + "\n" +
            "Max: " + sbyte.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("byte");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + byte.MinValue + "\n" +
            "Max: " + byte.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ushort");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + ushort.MinValue + "\n" +
            "Max: " + ushort.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("uint");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + uint.MinValue + "\n" +
            "Max: " + uint.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ulong");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + ulong.MinValue + "\n" +
            "Max: " + ulong.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("float");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + float.MinValue + "\n" +
            "Max: " + float.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("double");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + double.MinValue + "\n" +
            "Max: " + double.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("decimal");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
            "Min: " + decimal.MinValue + "\n" +
            "Max: " + decimal.MaxValue + "\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press anykey");
            Console.ReadKey();

        }
    }
}
