using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_InheritanceUserInput
{
    internal class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

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
        public bool HasCollar { get; set; }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Has Collar: {(HasCollar ? "Yes" : "No")}");
        }
    }
}
