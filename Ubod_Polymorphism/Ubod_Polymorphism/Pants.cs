using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Polymorphism
{
    internal class Pants
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        // Virtual method to display info (can be overridden by derived classes)
        public virtual void DisplayInformation()
        {
            Console.WriteLine("\n---- Pants Details ----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }

    // Derived class: Jeans
    internal class Jeans : Pants
    {
        public string FitType { get; set; } //Skinny, Slim, Regular

        // Override base class method
        public override void DisplayInformation()
        {
            Console.WriteLine("\n--- Jeans Details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Fit Type: {FitType}");
        }
    }

    // Derived class: Sweatpants
    internal class Sweatpants : Pants
    {
        public string Material { get; set; } //Cotton, Fleece, Polyester

        // Override base class method
        public override void DisplayInformation()
        {
            Console.WriteLine("\n--- Sweatpants Details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Material: {Material}");
        }
    }
}

