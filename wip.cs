using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Youch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vi = "Objective 13.2 // Egert Sulger"; // Random variable, never used again
            Console.WriteLine(vi);
            for (int i = 0; i < vi.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What area do you want to calculate?\nYour options are: Circle (1), Square (2) , Rectangle (3) and Pyramid (4).\nYou can input the letter L at any given time to exit."); //
            Console.WriteLine();
            Console.WriteLine();
            List<int> repy = new List<int>(); //rectangle and pyramid specifically
            while (true)
            {
                Console.Write("What shape's area would you like to find? ");
                string che = Console.ReadLine(); // che as in check, to see what is inputted. 
                if (che == "L")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for trying this program.");
                    break;
                }
                int val = int.Parse(che);
                int num = 0;

                if (val == 1)
                {
                    Console.Write("Input your value: ");
                    int rad = int.Parse(Console.ReadLine()); //Radius
                    double ar = cir(rad); //area, specifically for circle since pi gives weird answers, so double is the most accurate
                    string forar = string.Format("{0:0.00}", ar).Replace(".", ","); //forar as in formatted area
                    Console.WriteLine("The area of your circle is " + forar);
                    ar = cir(rad);
                }
                if (val == 2)
                {
                    Console.Write("Input your value: ");
                    int numb = int.Parse(Console.ReadLine()); //number
                    num = sqr(numb);
                    Console.WriteLine("The area of your sqaure is " + num);
                    num = sqr(numb);
                }   
                if (val == 3)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write("Input your values: ");
                        int side = int.Parse(Console.ReadLine());
                        repy.Add(side);
                    }
                    num = rec(repy);
                    Console.WriteLine("The area of your rectangle is " + num);
                    repy.Clear();
                }
                if (val == 4)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Input your values: ");
                        double edge = int.Parse(Console.ReadLine()); //it's sides of the triangle, but I couldn't generate a better name
                        int iedge = (int)edge;
                        repy.Add(iedge);
                    }
                    num = rec(repy);
                    Console.WriteLine("The area of your triangle is " + num);
                    repy.Clear();
                }
                
            }
        }
        public static int sqr(int x) //Square calculation
        {
            int sum = x * x;
            return sum;
        }
        public static double cir(int a) // circle calculation
        {
            double res = Math.PI * a * a; //have to use Math.PI, because 3.14 is not accurate enough
            return res;
        }
        public static int rec(List<int> x) //rectangle calculation. This was kinda a pain
        {
            int fin = x[0] * x[1]; //finish, as in finish the equation
            return fin;
        }
        public static double pyr(List<double> x) //triangle calculation, hopefully this won't be pain
        {
            double a = (x[0] + x[1] + x[2]) / 2;
            double res = Math.Sqrt(a * (a - x[0]) * (a - x[1] * (a - x[2])));
            return res;
        }
    }
}


