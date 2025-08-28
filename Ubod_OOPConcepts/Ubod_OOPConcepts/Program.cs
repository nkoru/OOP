using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_OOPConcepts
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: OOP Concepts

        static void Main(string[] args)
        {
            // Create PoloShirt object
            Shirt polo = new PoloShirt()
            {
                Brand = "Nike",
                Size = "M",
                HasCollar = true
            };

            // Create TShirt object
            Shirt tshirt = new TShirt()
            {
                Brand = "Uniqlo",
                Size = "L",
                SleeveLength = "Short"
            };

            // Polymorphic calls to overridden method
            polo.DisplayInformation();
            tshirt.DisplayInformation();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

    }
}
