using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_OOPUserInput
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: OOP Concepts with User Input
        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            Console.WriteLine("\tShirt Entry System");
            Console.WriteLine("Choose shirt type:");
            Console.WriteLine("1. Polo Shirt");
            Console.WriteLine("2. T-Shirt");
            Console.Write("Enter choice (1 or 2): ");
            string choice = Console.ReadLine();

            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("Invalid choice, please enter 1 or 2.");
                Console.ReadKey();
                goto Main;
            }

            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter size: ");
            string size = Console.ReadLine();

            Shirt shirt; // base class reference - polymorphism here

            if (choice == "1")
            {
                Console.Write("Does it have a collar? (y/n): ");
                string collarInput = Console.ReadLine().ToLower();

                bool hasCollar;
                if (collarInput == "y")
                    hasCollar = true;
                else if (collarInput == "n")
                    hasCollar = false;
                else
                {
                    Console.WriteLine("Invalid input for collar. Please enter 'y' or 'n'.");
                    Console.ReadKey();
                    goto Main;
                }

                shirt = new PoloShirt()
                {
                    Brand = brand,
                    Size = size,
                    HasCollar = hasCollar
                };
            }
            else
            {
                Console.Write("Enter sleeve length (e.g., Short, Long): ");
                string sleeveLength = Console.ReadLine();

                shirt = new TShirt()
                {
                    Brand = brand,
                    Size = size,
                    SleeveLength = sleeveLength
                };
            }

            // Polymorphic call to DisplayInformation
            shirt.DisplayInformation();

            Console.Write("\nDo you want to enter another shirt? (y/n): ");
            char answer = Console.ReadKey().KeyChar;

            if (answer == 'y' || answer == 'Y')
                goto Main;
            else if (answer == 'n' || answer == 'N')
                return;
            else
            {
                Console.WriteLine("\nInvalid input. Exiting...");
                return;
            }
        }
    }
}
