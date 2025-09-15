using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWIthComputation
{
    // Base class Shirt
    class Shirt
    {
        public string ShirtType {  get; set; }
        public double Price { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Shirt Type: {ShirtType}");
            Console.WriteLine($"Unit Price: {Price}");
        }
    }

    // Derived class PoloShirt with senior citizen discount
    class PoloShirt : Shirt
    {
        public bool IsSeniorCitizen;

        public double ComputeDiscountedPrice()
        {
            double discount = 0;
            if (IsSeniorCitizen)
            {
                discount = Price * 0.20; // 20% discount
            }
            return Price - discount;
        }
    }

    // Derived class TShirt with discount if total purchase exceeds certain amount
    class TShirt : Shirt
    {
        public int Quantity;

        public double ComputeDiscountedPrice()
        {
            double total = Price * Quantity;
            if (total > 1000)
            {
                return total * 0.90; // Apply 10% discount
            }
            else
            {
                return total; // No discount
            }
        }
    }
}

