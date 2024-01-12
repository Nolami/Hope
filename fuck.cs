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
            for (int i = 0; i < vi.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Arvaa arvottu luku väliltä 1-12 (lopetus L-merkillä)"); // The initial statement
            Console.WriteLine();
            Random ran = new Random(); // Generate the random element
            int rannum = ran.Next(1, 13); // Then assign it a specific value
            int se = 0; // This is just the counter, so number goes up each time
            int val = 0; //This is the total sum of everything, used at the end

            while (val != rannum) // Condition is, when value does not equal to the random number, exit
            {
                Console.Write("{0}. yritys: Arvaa luku ? ", se + 1); // Actual question plus incrementing counter, + 1 because otherwise it starts from +, se is 0 so.
                string ka = Console.ReadLine(); // The variable to store the question
                if (ka == "L") // What to do when it is a specfic letter
                {
                    Console.WriteLine("Lopetetaan...");
                    Console.WriteLine();
                    Console.WriteLine("Halusit lopettaa LUUSERI !!");
                    Console.WriteLine();
                    Console.WriteLine("Oikea vastaus oli {0}", rannum); // Explains what the actual correct number was
                }
                val = int.Parse(ka); // Now I turn it into integer, because I need a number too but a double readline is a double question
                Console.WriteLine(ka); // Per your own request, I print out the afformentioned guess aswell. your own words
                se++; // Increment it forever upwards, as logn as the guesser keeps going

                if (val == rannum) // What to do when the guess actually is the correct one
                {
                    Console.WriteLine();
                    Console.WriteLine("Onneksi olkoon, aravasit oikein !!!");
                    Console.WriteLine("Oikea vastaus oli {0}", rannum); // And yet again, telling you the correct answer
                }
            }

        }

    }
}
