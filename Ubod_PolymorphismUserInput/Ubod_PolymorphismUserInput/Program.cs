using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_PolymorphismUserInput
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Polymorphism with Shirt, PoloShirt, and TShirt Classes (User Input)

        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            Console.WriteLine("\tShirt Entry System");
            Console.WriteLine("Choose shirt type:");
            Console.WriteLine("1. Polo Shirt");
            Console.WriteLine("2. T-Shirt");
            Console.Write("\nEnter choice (1 or 2): ");
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

            Shirt myShirt;

            if (choice == "1")
            {
                // Polo Shirt input
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

                myShirt = new PoloShirt
                {
                    Brand = brand,
                    Size = size,
                    HasCollar = hasCollar
                };
            }
            else
            {
                // T-Shirt input
                Console.Write("Enter sleeve length (e.g., Short, Long): ");
                string sleeveLength = Console.ReadLine();

                myShirt = new TShirt
                {
                    Brand = brand,
                    Size = size,
                    SleeveLength = sleeveLength
                };
            }

            // Display details using polymorphism
            myShirt.DisplayInformation();

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
