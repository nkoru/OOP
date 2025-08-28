using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_AbstractionUserInput
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Abstraction with Shirt Class (User Input)

        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            Console.WriteLine("\tShirt Information Input");

            Console.Write("Enter the brand of the shirt: ");
            string brandInput = Console.ReadLine();

            Console.Write("Enter the size of the shirt: ");
            string sizeInput = Console.ReadLine();

            CustomShirt myShirt = new CustomShirt
            {
                Brand = brandInput,
                Size = sizeInput
            };

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
