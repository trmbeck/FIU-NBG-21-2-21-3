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
            // arithmetische Operatoren
            // Grundrechenarten +,-,*,/
            double wert = 234 / 1000.0;

            // Vergleichsoperatoren
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

            //Verknüpfungs-/logische Operatoren
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
            //   0  0  0  0  1  1  0  1 -> 12dez.
            //   0  0  0  0  1  0  0  0 ->  8dez.
            Console.WriteLine(ergebnis);



        }
    }
}
