using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Beep // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ev = "Tehtävä 10 vaihe 1 // Egert Sulger";
            Console.WriteLine(ev);
            for (int i = 0; i < ev.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine("Anna kokonaislukuja, niin lasken summan reaaliajassa");
            int vi = 0;
            int[] thi = new int[100];
            int sum = 0;
            while (sum <= 100)
            {
                Console.Write("Anna {0}. luku ? ", vi + 1);
                int al = int.Parse(Console.ReadLine());
                sum = sum + al;
                Console.WriteLine("Summa on nyt {0}", sum);
                vi++;
                if (sum >= 100)
                {
                    Console.WriteLine("Raja on saavutettu !");
                }

            }

        }

    }
}
