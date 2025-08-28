using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Inheritance
{
    //Base class Shirt
    internal class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Virtual method to display information (can be overridden)
        public virtual void DisplayInformation()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Shirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }

    // Derived class PoloShirt inherits Shirt
    internal class PoloShirt : Shirt
    {
        // Additional property specific to PoloShirt
        public bool HasCollar { get; set; }

        // Override to include HasCollar info
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Has Collar: {(HasCollar ? "Yes" : "No")}");
        }
    }
}

