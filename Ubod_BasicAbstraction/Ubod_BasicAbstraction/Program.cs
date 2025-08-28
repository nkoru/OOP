using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicAbstraction
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Abstraction with Shirt Class

        static void Main(string[] args)
        {
            // Must instantiate a concrete class, not abstract Shirt
            CustomShirt myShirt = new CustomShirt()
            {
                Brand = "Puma",
                Size = "M"
            };

            // Call the implemented abstract method
            myShirt.DisplayInformation();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
