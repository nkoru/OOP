using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_OOPUserInput
{
    // Abstract base class - abstraction
    internal abstract class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Abstract method, forces derived classes to implement this
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
