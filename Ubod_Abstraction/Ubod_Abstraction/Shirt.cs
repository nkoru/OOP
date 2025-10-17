using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Abstraction
{   
    // Base abstract class
    abstract class Bag
    {
        // Common Properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        // Constructor
        public Bag(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        // Abstract Methods (must be implemented by derived classes)
        public abstract void DisplayDetails();

        public abstract void CalculateDiscount(double percent);

        // Concrete Method (common action for all bags)
        public void Carry()
        {
            Console.WriteLine("Strap it up—your bag is coming with you!");
        }
    }

    // DERIVED CLASS 1 - SCHOOLBAG
    class SchoolBag : Bag
    {
        // Additional Property
        public int NumberOfCompartments { get; set; }

        // Constructor
        public SchoolBag(string brand, string color, double price, int compartments)
            : base(brand, color, price)
        {
            NumberOfCompartments = compartments;
        }

        // Overridden Methods
        public override void DisplayDetails()
        {
            Console.WriteLine("SCHOOL BAG DETAILS:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ₱{Price}");
            Console.WriteLine($"Compartments: {NumberOfCompartments}");
        }

        public override void CalculateDiscount(double percent)
        {
            double discount = Price * (percent / 100);
            double newPrice = Price - discount;
            Console.WriteLine($"Discounted Price (School Bag): ₱{newPrice}");
        }
    }

    // DERIVED CLASS 2 - TRAVELBAG
    class TravelBag : Bag
    {
        // Additional Property
        public double Capacity { get; set; }

        // Constructor
        public TravelBag(string brand, string color, double price, double capacity)
            : base(brand, color, price)
        {
            Capacity = capacity;
        }

        // Overridden Methods
        public override void DisplayDetails()
        {
            Console.WriteLine("\nTRAVEL BAG DETAILS:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ₱{Price}");
            Console.WriteLine($"Capacity: {Capacity} liters");
        }

        public override void CalculateDiscount(double percent)
        {
            // Different discount style for TravelBag
            double discount = (Price * percent / 100) + 100;
            double newPrice = Price - discount;
            Console.WriteLine($"Discounted Price (Travel Bag): ₱{newPrice}");
        }
    }
