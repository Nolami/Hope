using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Beep // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vi = "Tehtävä 10 vaihe 2 // Egert Sulger";
            Console.WriteLine(vi);
            for (int i = 0; i < vi.Length / 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine();
            Console.WriteLine("Arvaa arvottu luku väliltä 1-12 (lopetus L-merkillä)");
            Random ran = new Random();
            int rannum = ran.Next(1,13);
            int se = 0;
            int val = 0;
            while (val == rannum)
            {
                Console.Write("{0}. yritys: Arvaa luku ? ", se + 1);
                string ka = (Console.ReadLine());
                int vor = int.Parse(ka);
                Console.WriteLine(ka);
                se++;
                if (ka == "L")
                {
                    Console.WriteLine("Lopetetaan...");
                    Console.WriteLine();
                    Console.WriteLine("Halusit lopettaa LUUSERI !!");
                    Console.WriteLine();
                    Console.WriteLine("Oikea vastaus oli {0}", rannum);
                }
                if (vor == rannum)
                {
                    Console.WriteLine();
                    Console.WriteLine("Onneksi olkoon, aravasit oikein !!!");
                    Console.WriteLine("Oikea vastaus oli {0}", rannum);
                }
            }
            
        }

    }
}
