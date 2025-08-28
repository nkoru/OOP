using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicPolymorphism
{
    // Base class Shirt
    internal class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Virtual method for display info, overridable by derived classes
        public virtual void DisplayInformation()
        {
            Console.WriteLine("\nShirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }

    // Derived class Polo Shirt
    internal class PoloShirt : Shirt
    {
        public bool HasCollar { get; set; }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Has Collar: {(HasCollar ? "Yes" : "No")}");
        }
    }

    // Another derived class Tee Shirt
    internal class TeeShirt : Shirt
    {
        public string SleeveLength { get; set; } // ex. Short/Long

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Sleeve Length: {SleeveLength}");
        }
    }
}
