using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Abstraction
{
    abstract class Shirt // Abstract base class
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        // Parameterized constructor
        public Shirt(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        // Abstract method
        public abstract void DisplayInfo();

        // Concrete method
        public double DiscountPrice(double discountPercent)
        {
            return Price - (Price * (discountPercent / 100));
        }
    }

    // Derived class 1
    class PoloShirt : Shirt
    {
        public string Fabric { get; set; }

        // Parameterized constructor that calls base constructor
        public PoloShirt(string brand, string color, double price, string fabric)
            : base(brand, color, price)
        {
            Fabric = fabric;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Polo Shirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Fabric: {Fabric}");
            Console.WriteLine($"Price: ₱{Price}");
        }
    }

    // Derived class 2
    class TShirt : Shirt
    {
        public string Design { get; set; }

        // Parameterized constructor that calls base constructor
        public TShirt(string brand, string color, double price, string design)
            : base(brand, color, price)
        {
            Design = design;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("T-Shirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Design: {Design}");
            Console.WriteLine($"Price: ₱{Price}");
        }
    }
}
