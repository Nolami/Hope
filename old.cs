using System;

namespace sex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] vi = new int[1, 9];
            vi[0, 1] = 1;
            vi[0, 2] = 2;
            vi[0, 3] = 3;
            vi[0, 4] = 4;
            vi[0, 5] = 5;
            vi[0, 6] = 6;
            vi[0, 7] = 7;
            vi[0, 8] = 8;
            Console.Write("Number 1-8: ");
            int vie = int.Parse(Console.ReadLine());
            if (vie >= 1 && vie <= 8)
            {
                Console.WriteLine($"Here: {vi[0, vie]}");
            }
        }
    }
}
