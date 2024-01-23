using System;
using System.Text;

namespace bean
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tehtävä 8.4 / Egert Sulger");
            //int vi = int.Parse(Conosle.ReadLine());
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            string[,] herol = new string[4, 4];
            herol[0, 0] = "Ana";
            herol[1, 0] = "Support";
            herol[0, 1] = "Bastion";
            herol[1, 1] = "Defence";

            herol[0, 2] = "Brigette";
            herol[1, 2] = "Support";
            herol[0, 3] = "D.Va(Mech";
            herol[1, 3] = "Tank";

            int[,] hamor = new int[4, 4];
            hamor[0, 0] = 200;
            hamor[1, 0] = 0;
            hamor[0, 1] = 200;
            hamor[1, 0] = 100;
            hamor[0, 2] = 200;
            hamor[1, 2] = 50;
            hamor[0, 3] = 400;
            hamor[1, 3] = 200;

            //string[] heroes = { "Ana", "Bastion", "Brigette", "D.Va (Mech)" }; // This is all the heroes
            //string[] roles = { "Support", "Defence", "Tank" }; // Got the roles too
            //int[] hp = { 200, 400 }; // And of course, health
            //int[] armor = { 0, 50, 100, 200 }; // And who could forget, armour
            int nal = 0;
            Console.WriteLine("HEROt ovat seuraavat:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("({0}) {1}", i + 1, herol[0, i]);
            }
            Console.WriteLine();
            Console.Write("Valitse, minkä HEROn tiedot haluat nähdä ? ");
            int bee = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (bee == 1)
            {

                Console.WriteLine(herol[0,0] + " " + herol[1,0] + " " + hamor[0,0] + " " + hamor[1,0]); // We got Ana

            }
            else if (bee == 2)
            {
                Console.WriteLine(herol[0, 1] + " " + herol[1, 1] + " " + hamor[0, 1] + " " + hamor[1, 1]); // Then Bastion
            }
            else if (bee == 3)
            {
                Console.WriteLine(herol[0, 2] + " " + herol[1, 2] + " " + hamor[0, 2] + " " + hamor[1, 2]); // Then we got Brigette
            }
            else if (bee == 4)
            {
                Console.WriteLine(herol[0, 3] + " " + herol[1, 3] + " " + hamor[0, 3] + " " + hamor[1, 3]); // And Finally, D.Va
            }
        }
    }
}


