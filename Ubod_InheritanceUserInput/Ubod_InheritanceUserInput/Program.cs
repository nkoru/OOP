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
        // Exercise: Inheritance with User Input

        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            Console.Write("Chooose the type of shirt (1 for Polo Shirt, 2 for Tshirt): ");
            string choice = Console.ReadLine();  

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("\tPolo Shirt Input");

                Console.Write("\nEnter the brand of Polo Shirt: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the size of the Polo Shirt: ");
                string size = Console.ReadLine();

                Console.Write("Does Polo Shirt have a collar? (yes/no): ");
                bool hasCollar = Console.ReadLine().ToLower() == "true";

                Console.Write("Enter sleeve lngth of Polo Shirt? (short/long): ");
                bool sleeveLength = Console.ReadLine().ToLower() == "short";

                PoloShirt myPolo = new PoloShirt(brand, size, hasCollar, sleeveLength);
                Console.WriteLine("\nPolo Shirt Details");
                myPolo.PoloShirtDetails();
            }

            if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("\tPolo Shirt Input");

                Console.WriteLine("Enter the brand of TShirt: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the size of the Polo Shirt: ");
                string size = Console.ReadLine();

                Console.Write("Does Polo Shirt have a collar? (yes/no): ");
                bool closeNeck = Console.ReadLine().ToLower() == "true";

                Console.Write("Enter sleeve lngth of Polo Shirt? (yes/no): ");
                bool vNeck = Console.ReadLine().ToLower() == "true";

                Tshirt myTshirt = new Tshirt (brand, size, closeNeck, vNeck);
                Console.WriteLine("\nTShirt Details");
                myTshirt.TShirtDetails();
            }

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
