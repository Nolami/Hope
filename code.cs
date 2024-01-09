using System;

namespace Youch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int am = 0;
            
            
            Console.Write("Anna paloiteltava lause? ");
            string vi = Console.ReadLine();
            

            Console.WriteLine();
            string[] val = vi.Split();
            foreach (string s in val)
            {
                Console.WriteLine(s);
                am = am + 1;
            }
            Console.WriteLine();
            Console.WriteLine("Sanoja oli {0} kappaletta", am);
            Console.WriteLine();

            int vie = 0;
            double[] num = { 1, 2, 3, 4 };
            foreach(int i in num)
            {
                Console.WriteLine(i);
                vie = vie + 1;
                
            }
            Console.WriteLine($"Amount of numbers: {vie}");
            }
    }
}