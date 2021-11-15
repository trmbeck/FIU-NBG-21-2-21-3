using System;

namespace Netzwerk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablendeklaration
            byte IP1o1;
            byte IP1o2;
            byte IP1o3;
            byte IP1o4;

            byte IP2o1, IP2o2, IP2o3, IP2o4;
            byte NMo1, NMo2, NMo3, NMo4;
            byte NA1o1, NA1o2, NA1o3, NA1o4;
            byte NA2o1, NA2o2, NA2o3, NA2o4;

            Console.WriteLine("Bitte 1. IP-Adresse eingeben: ");
            string eingabe = Console.ReadLine();
            IP1o1 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            IP1o2 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            IP1o3 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            IP1o4 = Convert.ToByte(eingabe);

            Console.WriteLine("Bitte 2. IP-Adresse eingeben: ");
            eingabe = Console.ReadLine();
            IP2o1 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            IP2o2 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            IP2o3 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            IP2o4 = Convert.ToByte(eingabe);

            Console.WriteLine("Bitte Subnet-Maske eingeben: ");
            eingabe = Console.ReadLine();
            NMo1 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            NMo2 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            NMo3 = Convert.ToByte(eingabe);

            eingabe = Console.ReadLine();
            NMo4 = Convert.ToByte(eingabe);

            NA1o1 = (byte)(IP1o1 & NMo1);
            NA1o2 = (byte)(IP1o2 & NMo2);
            NA1o3 = (byte)(IP1o3 & NMo3);
            NA1o4 = (byte)(IP1o4 & NMo4);

            NA2o1 = (byte)(IP2o1 & NMo1);
            NA2o2 = (byte)(IP2o2 & NMo2);
            NA2o3 = (byte)(IP2o3 & NMo3);
            NA2o4 = (byte)(IP2o4 & NMo4);

            Console.WriteLine("Die 1. Netzadresse lautet:");
            Console.WriteLine(NA1o1 + "." + NA1o2 + "." + NA1o3 + "." + NA1o4);

            Console.WriteLine("Die 2. Netzadresse lautet:");
            Console.WriteLine(NA2o1 + "." + NA2o2 + "." + NA2o3 + "." + NA2o4);

            if (NA1o1 == NA2o1 && NA1o2 == NA2o2 && NA1o3 == NA2o3 && NA1o4 == NA2o4)
            {
                Console.WriteLine("Die IP-Adressen sind im gleichen Netzwerk");
            }
            else
            {
                Console.WriteLine("Die IP-Adressen sind in unterschiedlichen Netzwerken!");
            }
        }
    }
}
