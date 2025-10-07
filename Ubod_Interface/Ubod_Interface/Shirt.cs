using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Interface
{
    class Shirt // Base Class

    {
        // Fields / Properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        // Parameterized Constructor
        public Shirt(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        // Implemented Methods
        public virtual void DisplayInfo() // Method to display shirt information
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: Php {Price:F2}");
        }
    }

    // Derived Class 1
    class PoloShirt : Shirt, IShirtDetails
    {
        public string Material { get; set; } // Additional Property

        public PoloShirt(string brand, string color, double price, string material) : base(brand, color, price)
        {
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Polo Shirt Details ---");
            base.DisplayInfo();
            Console.WriteLine($"Material: {Material}\n");
        }

        public void CalculateDiscount (double percent) // Method to calculate discount
        {
            double discount = Price * (percent / 100); // Calculate discount amount
            double discountedPrice = Price - discount; // Calculate discounted price

            Console.WriteLine($"Polo Shirt '{Material}' discounted by  {percent}%"); // Display discount percentage
            Console.WriteLine($"Discounted Price: Php {discountedPrice:F2}\n");
        }
    }

    // Derived Class 2
    class TShirt : Shirt, IShirtDetails
    {
        public string Size { get; set; }

        public TShirt(string brand, string color, double price, string size) : base(brand, color, price)
        {
            Size = size;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- T-Shirt Details ---");
            base.DisplayInfo();
            Console.WriteLine($"Size: {Size}\n");
        }

        public void CalculateDiscount(double percent) 
        {
            double discount = Price * (percent / 100); 
            double discountedPrice = Price - discount; 

            Console.WriteLine($"Tshirt '{Size}' discounted by {percent}%");
            Console.WriteLine($"Discounted Price: Php {discountedPrice:F2}");
        }
    }
}
