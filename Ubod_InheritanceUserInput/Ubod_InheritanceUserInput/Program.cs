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

                Console.Write("Does Polo Shirt have a collar? (y/n): ");
                string collarInput = Console.ReadLine();
                bool hasCollar = collarInput == "y" || collarInput == "Y";

                Console.Write("Enter sleeve length of Polo Shirt? (short/long): ");
                string sleeveInput = Console.ReadLine();
                bool isShortSleeve = sleeveInput == "short" || sleeveInput == "SHORT" || sleeveInput == "Short";

                //Create an instance of the PoloShirt Class
                PoloShirt myPolo = new PoloShirt(brand, size, hasCollar, isShortSleeve);
                Console.WriteLine("\nPolo Shirt Details");
                myPolo.PoloShirtDetails(); //Display PoloShirt Information
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("\tTShirt Input");

                Console.Write("\nEnter the brand of TShirt: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the size of the TShirt: ");
                string size = Console.ReadLine();

                Console.Write("Enter neck type of T-Shirt (Round or V -neck): ");
                string neckInput = Console.ReadLine();

                Console.Write("Does T-Shirt have a pocket? (y/n): ");
                string pocketInput = Console.ReadLine();
                bool hasPocket = pocketInput == "y" || pocketInput == "Y";

                //Create an instance of the TShirt Class
                Tshirt myTshirt = new Tshirt (brand, size, neckInput, hasPocket);

                //Display TShirt Information
                Console.WriteLine("\nTShirt Details");
                myTshirt.TShirtDetails(); 
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            //Prompt for user 
            Console.Write("\nDo you want to enter another Shirt? (y/n): ");
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
