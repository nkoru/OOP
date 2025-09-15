using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWIthComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instance of PoloShirt and set properties 
            PoloShirt polo = new PoloShirt();

            polo.ShirtType = "Polo Classic";
            polo.Price = 1250;
            polo.IsSeniorCitizen = true; // Senior citizen eligible for discount

            Console.WriteLine("\n---- Polo Shirt ----\n");
            polo.DisplayDetails();

            Console.WriteLine($"Final Price after Discount: {polo.ComputeDiscountedPrice()}\n");

            // Create instance of TShirt and set properties 
            TShirt tshirt = new TShirt();

            tshirt.ShirtType = "Basic T-Shirt";
            tshirt.Price = 600;
            tshirt.Quantity = 2; // Buying 2 items

            Console.WriteLine("\n---- T-Shirt ----\n");
            tshirt.DisplayDetails();

            Console.WriteLine($"Final Price after Discount: {tshirt.ComputeDiscountedPrice()}\n");

            Console.ReadKey();
        }
    }
}
