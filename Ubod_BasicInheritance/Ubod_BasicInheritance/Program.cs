using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicInheritance
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Inheritance with Shirt and PoloShirt Classes

        static void Main(string[] args)
        {
            // Instantiate and set properties directly
            PoloShirt myPolo = new PoloShirt()
            {
                Brand = "Adidas",
                Size = "L",
                HasCollar = true
            };

            // Display the details
            myPolo.DisplayInformation();

            // Wait for user to press a key before closing
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
