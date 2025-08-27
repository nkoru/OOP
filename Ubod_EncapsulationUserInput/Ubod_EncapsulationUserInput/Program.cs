using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_EncapsulationUserInput
{
    internal class Program
    {
        //Name: Beatrice Nicole Ubod
        //Section: IT306

        //Exercise: Encapsulation with User Input

        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            //Prompt for user input
            Console.WriteLine("\tShirt Information Input");

            //Prompt for the user and get input for Shirt properties
            Console.WriteLine("\nEnter the brand of the shirt: ");
            string brandInput = Console.ReadLine();

            Console.WriteLine("\nEnter the size of the shirt: ");
            string sizeInput = Console.ReadLine();

            //Instantiate the Shirt class
            Shirt myShirt = new Shirt
            {
                Brand = brandInput,
                Size = sizeInput
            };

            //Call the method to display the Shirt details
            myShirt.DisplayInformation();

            //Input another
            Console.Write("\nDo you want to enter another shirt? (y/n)");
            char answer = Convert.ToChar(Console.ReadKey());
            if (answer == 'y' || answer == 'Y')
            {
                goto Main;
            }
            else if (answer == 'n' || answer == 'N')
            {
                Console.Write("Invalid input! Please enter 'y' or 'n'.");

                goto Main;
            }

            Console.ReadKey();
        }
    }
    }
}
