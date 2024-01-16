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

//Updated code

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

            am = 0;
            double[] num = { 1, 2, 3, 4 };
            foreach(int i in num)
            {
                Console.WriteLine(i);
                am = am + 1;
                
            }
            Console.WriteLine($"Amount of numbers: {am}");
            Console.WriteLine();

            string[] na = { "Vin", "Diesel", "Mark", "Anthony" };
            am = 0;
            foreach(string e in na)
            {
                Console.WriteLine(e);
                am = am + 1;
            }
            Console.WriteLine($"Name amount: {am}");
            }
    }
}

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Beep // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wil = "Tehtävä 11 // Egert Sulger";
            Console.WriteLine(wil);
            Console.WriteLine();
            
            for (int i = 0; i < wil.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
            int vi = 0; // counter
            int val = 0; //value itself, doesn't need to be a global but too late now
            List<int> ni = new List<int>(); //Actual list
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("{0}. listan luku ? ", vi +1); //Question
                val = int.Parse(Console.ReadLine()); //value
                Console.WriteLine();
                ni.Add(val); //Add value to list
                vi++;

            }
            Console.WriteLine();
            foreach (int von in ni) // take all values from the list
            {
                Console.WriteLine(von); //Print those values
            }

        }   


    }

 }
