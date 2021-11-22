using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aufgabenpool_Kapitel_1_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int ip1_1, ip1_2, ip1_3, ip1_4;
            int ip2_1, ip2_2, ip2_3, ip2_4;
            int s1, s2, s3, s4;

            Console.WriteLine("Subnetting Version 1.0\n");

            Console.WriteLine("Bitte die 1. IP-Adresse eingeben: ");
            ip1_1 = Convert.ToInt32(Console.ReadLine());
            ip1_2 = Convert.ToInt32(Console.ReadLine());
            ip1_3 = Convert.ToInt32(Console.ReadLine());
            ip1_4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Bitte die 2. IP-Adresse eingeben: ");
            ip2_1 = Convert.ToInt32(Console.ReadLine());
            ip2_2 = Convert.ToInt32(Console.ReadLine());
            ip2_3 = Convert.ToInt32(Console.ReadLine());
            ip2_4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Bitte die Subnet-Mask eingeben: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            s3 = Convert.ToInt32(Console.ReadLine());
            s4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("1. IP-Adresse: ");
            WriteIP(ip1_1, ip1_2, ip1_3, ip1_4);
            Console.WriteLine("Die 1. Netzadresse lautet:");
            WriteIP(ip1_1 & s1,ip1_2 & s2,ip1_3 & s3,ip1_4 & s4);

            Console.WriteLine();
            Console.WriteLine("Die 2. Netzadresse lautet:");
            Console.WriteLine((ip2_1 & s1) + " . " + (ip2_2 & s2) + " . " + (ip2_3 & s3) + " . " + (ip2_4 & s4));



            //Erweiterung writeIP und parseIP

            string ipaddressAsString = Console.ReadLine(); // "192.168.1.1"
            int[] OktettArray = ParseIpAddress(ipaddressAsString);
            for (int i = 0; i < OktettArray.Length; i++)
            {
                Console.WriteLine(OktettArray[i]);
            }

            ip1_1 = OktettArray[0];
            ip1_2 = OktettArray[1];
            ip1_3 = OktettArray[2];
            ip1_4 = OktettArray[3];

            WriteIP(ip1_1, ip1_2, ip1_3, ip1_4);

            void WriteIP(int o1, int o2, int o3, int o4)
            {
                Console.WriteLine(o1 + "." + o2 + "." + o3 + "." + o4);
            }


            int[] ParseIpAddress(string address)
            {
                // beispiel: 192.168.001.001
                int[] ipaddress = new int[4];

                for (int i = 0; i < 13; i += 4)
                {
                    string oktett = address[i].ToString() + address[i + 1].ToString() + address[i + 2].ToString();
                    ipaddress[i/4] = Convert.ToInt32(oktett);
                }
                return ipaddress;
            }
        }
    }
}
