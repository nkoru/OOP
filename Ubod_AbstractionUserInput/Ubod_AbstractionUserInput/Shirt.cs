using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_AbstractionUserInput
{
    // Abstract base class
    internal abstract class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Abstract method to display info
        public abstract void DisplayInformation();
    }

    // Concrete class implementing the abstract Shirt
    internal class CustomShirt : Shirt
    {
        public override void DisplayInformation()
        {
            Console.WriteLine("\nShirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}
