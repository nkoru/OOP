using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_PolymorphismUserInput
{
    internal class Shirt
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        public virtual void DisplayInformation()
        {
            Console.WriteLine("\nShirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }

    internal class PoloShirt : Shirt
    {
        public bool HasCollar { get; set; }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Has Collar: {(HasCollar ? "Yes" : "No")}");
        }
    }

    internal class TShirt : Shirt
    {
        public string SleeveLength { get; set; }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Sleeve Length: {SleeveLength}");
        }
    }
}
