using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace viv // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static string name = " ";
        private static int age = 0;
        private static bool cont = true;
        enum elvivi
        {
            AName = 1, AAge = 2, ShNa = 3, ShAge = 4, exit = 5
        }
        static void Main(string[] args)
        {
            string vi = "Objective 17 // Egert Sulger";
            Console.WriteLine(vi);
            for (int i = 0; i < vi.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("Welcome to the program.\nChoose an option by typing in a number: ");
            Console.WriteLine();
            List<string> opt = new List<string>() { "Input your name", "Input your age", "Show your name", "Show your age", "Exit" };


            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}. {1}", i +1, opt[i]);
                }
                break;
            }




        }


        static void na(elvivi s) //name
        {
            switch (s)
            {
                case elvivi.AName:
                    AName();
                    break;
                case elvivi.AAge:
                    AAge();
                    break;
                case elvivi.ShNa:
                    ShNa();
                    break;
                case elvivi.ShAge:
                    ShAge();
                    break;
                case elvivi.exit:
                    exit();
                    break;
                default:
                    Console.WriteLine("Given number is not within the choices");
                    break;
            }
        }
        static string AName()
        {
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            return "Your name is" + name;
        }
        static int AAge()
        {
            Console.Write("Input your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                return age;
            }
            else
            {
                Console.WriteLine("Value must not be below 0");
                return 0;
            }
        }
        static string ShNa()
        {
            return name;
        }
        static int ShAge()
        {
            return age;
        }
        static void exit()
        {
            Console.WriteLine("Ending program.\nThank you for using me");
            cont = false;
        }
    }
}
