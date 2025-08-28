using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_InheritanceUserInput
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Inheritance with Shirt and PoloShirt Classes (User Input)

        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            Console.WriteLine("\tPolo Shirt Information Input");

            Console.Write("\nEnter the brand of the shirt: ");
            string brandInput = Console.ReadLine();

            Console.Write("Enter the size of the shirt: ");
            string sizeInput = Console.ReadLine();

            Console.Write("Does it have a collar? (y/n): ");
            string collarInput = Console.ReadLine().ToLower();

            bool hasCollar;
            if (collarInput == "y")
                hasCollar = true;
            else if (collarInput == "n")
                hasCollar = false;
            else
            {
                Console.WriteLine("\nInvalid input for collar. Please enter 'y' or 'n'.");
                Console.ReadKey();
                goto Main;
            }

            PoloShirt myPolo = new PoloShirt()
            {
                Brand = brandInput,
                Size = sizeInput,
                HasCollar = hasCollar
            };

            myPolo.DisplayInformation();

            Console.Write("\nDo you want to enter another Polo Shirt? (y/n): ");
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
