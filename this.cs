using System;
using System.Diagnostics.CodeAnalysis;

namespace Youch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int am = 0;
            string v = "Tehtävä 9 // Egert Sulger";
            Console.WriteLine("Tehtävä 9 // Egert Sulger");
            
            for (int i = 0; i <= v.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Anna viisi lukua niin lasken niiden keskiarvon");
            int[] thi = new int[5];
            for (int i = 0; i < 5; i++)
            
            {
                
                Console.Write("Anna {0}. luku ? ", am + 1);
                int na = int.Parse(Console.ReadLine());
                am = am + 1;
                thi[i] = na;
                //am++;
            }
            int sum = 0;
            foreach(int nu in thi)
            {
                sum += nu;
            }
            sum = sum / 5;
            string su = string.Format("{0:0.00}", sum);
            Console.WriteLine("Keskiarvo on {0}", su);
        }
    }
}