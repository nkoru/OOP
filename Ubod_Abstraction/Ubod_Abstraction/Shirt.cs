using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Abstraction
{
    // Abstract base class for Pants - demonstrates abstraction by defining common properties and methods
    abstract class Pants
    {
        // Common properties for all pants types
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        // Parameterized constructor for base class
        public Pants(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        // Abstract method - must be implemented by derived classes for unique display
        public abstract void DisplayInfo();
    }


    class DressPants : Pants
    {
        public string Fabric { get; set; }

        public DressPants(string brand, string color, double price, string fabric) : base(brand, color, price)
        {
            Fabric = fabric;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Dress Pants Information ===\n");
            Console.WriteLine("Dress Pants Details (Formal Wear):");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Fabric: {Fabric}");
            Console.WriteLine($"Price: Php {Price}\n");
        }

        public void DiscountPrice(double discountPercent)
        {
            double discount = Price * (discountPercent / 100);
            Price -= discount;

            Console.WriteLine($"Dresspants '{Brand}' discounted by {discountPercent}%");
            Console.WriteLine($"Discount Amount: Php {Price:F2}\n");
        }
    }

    class CasualPants : Pants
    {
        public string FitType { get; set; }

        public CasualPants(string brand, string color, double price, string fitType) : base(brand, color, price)
        {
            FitType = fitType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Casual Pants Information ===\n");
            Console.WriteLine("Casual Pants Details (Everyday Wear):");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Fit Type: {FitType}");
            Console.WriteLine($"Price: Php {Price}\n");
        }

        public void DiscountPrice(double discountPercent)
        {
            double discount = Price * (discountPercent / 100);
            Price -= discount;

            Console.WriteLine($"Casualpants '{Brand}' discounted by {discountPercent}%");
            Console.WriteLine($"Discount Amount: Php {Price:F2}\n");
        }
    }
}
