using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicPolymorphism
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Polymorphism with Shirt, PoloShirt, and TShirt Classes

        static void Main(string[] args)
        {   
            // Using polymorphism with base class reference
            Shirt myShirt;

            // PoloShirt instance assigned to Shirt reference
            myShirt = new PoloShirt()
            {
                Brand = "Nike",
                Size = "M",
                HasCollar = true
            };

            myShirt.DisplayInformation();  // Calls PoloShirt's overridden method

            // TShirt instance assigned to Shirt reference
            myShirt = new TeeShirt()
            {
                Brand = "Uniqlo",
                Size = "L",
                SleeveLength = "Short"
            };

            myShirt.DisplayInformation();  // Calls TeeShirt's overridden method

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
