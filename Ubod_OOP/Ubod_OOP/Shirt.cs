using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_OOP
{
    // Abstract base class - abstraction
    internal abstract class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void DisplayInformation();
    }

    // Derived class PoloShirt - inheritance
    internal class PoloShirt : Shirt
    {
        public bool HasCollar { get; set; }

        public override void DisplayInformation()
        {
            Console.WriteLine("\nPolo Shirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Has Collar: {(HasCollar ? "Yes" : "No")}");
        }
    }

    // Derived class TShirt - inheritance
    internal class TShirt : Shirt
    {
        public string SleeveLength { get; set; }

        public override void DisplayInformation()
        {
            Console.WriteLine("\nT-Shirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Sleeve Length: {SleeveLength}");
        }
    }
}
