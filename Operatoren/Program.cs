using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 1, operand2 = 2;
            bool aussage1 = true, aussage2 = false;
            // Operatoren

            #region Verkettungsoperator
            string s1 = "Hallo";
            string s2 = "FIU";
            string s3 = s1 + s2;
            #endregion


            #region Arithmetische Operatoren
            // Grundrechenarten +,-,*,/,%
            // Punkt- vor Strichrechnung
            // Von links nach rechts
            double wert = 234 / 1000.0;     // Division
            wert = 234 * 12;                // Multiplikation
            wert = wert + 1;                // Addition
            wert = 234 - 1;                 // Subtraktion
            wert = 16 % 3;                  // Modulo -> Rest einer Ganzzahldivision
                                            // 16 / 3 mit Rest -> 5 Rest 1
            wert = 29 % 7;                  // wert ist 1

            int result = 17 / 10;           // Ganzzahldivision ohne Rest -> 17 / 10 ergibt 1
            Console.WriteLine("Ganzzahldivision: " + result.ToString());

            int a = 1234;
            Console.WriteLine("einerstelle: " + a % 10);
            Console.WriteLine("zehner und einerstelle: " + a % 100);
            Console.WriteLine("hunderter, zehner und einerstelle: " + a % 1000);
            Console.WriteLine("nur Zehnerstelle: " + a % 100 / 10);

            #endregion


            #region Vergleichsoperatoren
            // Ist gleich
            bool vergleich = operand1 == operand2;
            if (operand1 == operand2) Console.WriteLine("Ist gleich");

            // ungleich
            vergleich = operand1 != operand2; // true wenn operand1 unterschiedlich zu operand2 ist
            // größer als
            vergleich = operand1 > operand2;
            // kleiner als
            vergleich = operand1 < operand2;
            // größer oder gleich
            vergleich = operand1 >= operand2;
            // kleiner oder gleich
            vergleich = operand1 <= operand2;
            #endregion


            #region Verknüpfungs-/logische Operatoren
            // AND &, OR |, NOT !, XOR ^
            /*
                AND
                A  &  B  |  C
                ---------|---
                0     0  |  0
                0     1  |  0
                1     0  |  0
                1     1  |  1

                OR
                A  |  B  |  C
                ---------|---
                0     0  |  0
                0     1  |  1
                1     0  |  1
                1     1  |  1

                NOT
                A  | !A
                -------
                0  |  1
                1  |  0

                XOR
                A  ^  B  |  C
                ---------|---
                0     0  |  0
                0     1  |  1
                1     0  |  1
                1     1  |  0

                Sonderfall:
                Aussage1 && Aussage2 --> Ist Aussage1 falsch, wird Aussage2 nicht ausgewertet, dann ist der Vergleich false
                Aussage1 || Aussage2 --> Ist Aussage1 wahr, wird Aussage2 nicht ausgewertet, dann ist der Vergleich true
             */
            if (aussage1 && aussage2) Console.WriteLine("Beide Aussage sind wahr");
            if (aussage1 && !aussage2) Console.WriteLine("Aussage1 ist wahr, Aussage2 ist falsch");
            if ((aussage1 && !aussage2) || ((operand1 > operand2) && (operand1 < 10))) Console.WriteLine("wahr oder falsch:-)");

            int ergebnis = 10 & 12;
            // 128 64 32 16  8  4  2  1
            //   0  0  0  0  1  0  1  0 -> 10dez.
            //   0  0  0  0  1  1  0  0 -> 12dez.
            //   0  0  0  0  1  0  0  0 ->  8dez.
            Console.WriteLine(ergebnis);

            //   0  0  1  1  1  0  1  1 -->   58 << 1
            //   0  1  1  1  0  1  1  0 -->  118 << 1
            //   1  1  1  0  1  1  0  0 -->  236 >> 3
            //   0  0  0  1  1  1  0  1 -->   29
            #endregion


            #region Verschiebeoperatoren
            // >> nach rechts verschieben
            // << nach links verschieben
            ergebnis = 59;
            Console.WriteLine(ergebnis + " um 1 Bit nach links schieben:");
            Console.WriteLine(ergebnis << 1);
            Console.WriteLine(ergebnis + " um 2 Bits nach links schieben:");
            Console.WriteLine(ergebnis << 2);
            Console.WriteLine(ergebnis + " um 1 Bits nach rechts schieben:");
            Console.WriteLine(ergebnis >> 1);
            #endregion


            #region Zuweisungsoperatoren
            ergebnis = operand1;    // einfache Zuweisung
            ergebnis += 1;          // ergebnis = ergebnis + 1;
            ergebnis *= 10;         // ergebnis = ergebnis * 10;
            ergebnis /= 2;          // ergebnis = ergebnis / 2;
            ergebnis -= 5;          // ergebnis = ergebnis - 5;
            ergebnis &= 7;          // ergebnis = ergebnis & 7;
            aussage1 |= aussage2;   // aussage1 = aussage1 | aussage2;
            aussage2 ^= aussage1;   // aussage2 = aussage2 ^ aussage1;
            #endregion


            #region Inkrement und Dekrement
            int i = 10;
            int i1 = 10;
            int i2 = 10;
            int i3 = 10;
            int i4 = 10;
            // i += 1
            i++;        //Postfix-Inkrement - i wird um 1 erhöht und wieder in i gespeichert
            i--;        //Postfix-Dekrement - i wird um 1 vermindert und wieder in i gespeichert
            ++i;        //Präfix-Inkrement - i wird um 1 erhöht und wieder in i gespeichert
            --i;        //Präfix-Dekrement - i wird um 1 vermindert und wieder in i gespeichert

            Console.WriteLine("i:" + i);

            ergebnis = 10 + i1++;
            Console.WriteLine("i1++: " + ergebnis + "\ti1:" + i1);

            ergebnis = 10 + i2--;
            Console.WriteLine("i2--: " + ergebnis + "\ti2:" + i2);

            ergebnis = 10 + ++i3;
            Console.WriteLine("++i3: " + ergebnis + "\ti3:" + i3);

            ergebnis = 10 + --i4;
            Console.WriteLine("--i4: " + ergebnis + "\ti4:" + i4);
            #endregion

        }
    }
}
