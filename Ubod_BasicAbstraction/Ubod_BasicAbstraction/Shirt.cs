using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicAbstraction
{
    // Abstract class Shirt — cannot instantiate this directly
    internal abstract class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Abstract method — must be implemented by derived classes
        public abstract void DisplayInformation();
    }

    // Concrete class implementing Shirt abstraction
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
