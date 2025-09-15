using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithComputationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            Console.Write("Chooose the type of shirt (1 for Polo Shirt, 2 for Tshirt): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                // Input details for PoloShirt
                PoloShirt polo = new PoloShirt();

                Console.Write("Enter Polo Shirt Brand: ");
                polo.ShirtType = Console.ReadLine();

                Console.Write("Enter Polo Shirt Price: ");
                polo.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Is the buyer a senior citizen? (yes/no): ");
                string seniorInput = Console.ReadLine().ToLower();
                polo.IsSeniorCitizen = (seniorInput == "yes");

                Console.WriteLine("\n---- Polo Shirt ----\n");
                polo.DisplayDetails();

                Console.Write($"Final Price after Discount: {polo.ComputeDiscountedPrice()}\n");
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("\tTShirt Input");
                // Input details for TShirt
                TShirt tshirt = new TShirt();

                Console.Write("\nEnter T-Shirt Brand: ");
                tshirt.ShirtType = Console.ReadLine();

                Console.Write("Enter T-Shirt Price: ");
                tshirt.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter quantity of T-Shirts to buy: ");
                tshirt.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n---- T-Shirt ----\n");
                tshirt.DisplayDetails();

                Console.Write($"Final Price after Discount: {tshirt.ComputeDiscountedPrice()}\n");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
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
