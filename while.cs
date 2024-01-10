using System;

namespace Beep // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insert number");
            Console.WriteLine();

            Console.Write("Anna luku johon asti tulostan? ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int vi = 0;
            while (vi < e)
            {
                vi++;
                Console.WriteLine($"{vi}");
            }

            Console.WriteLine("Number normal, end if over 10: ") ;
            Console.WriteLine();
            e = 0;
            
            while (e <= 10)
            {
                Console.Write("Number, now ");
                e = int.Parse(Console.ReadLine());
                if (e <= 10)
                {
                    e++;
                    Console.WriteLine(e);
                }
                
                
            }

            }

        }
    }
