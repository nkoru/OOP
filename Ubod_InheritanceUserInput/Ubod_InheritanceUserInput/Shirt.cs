using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_InheritanceUserInput
{
    internal class Shirt
    {
        //Fields for the Base (Shirt) Class
        public string brand;
        public string size;

        public Shirt (string shirtBrand, string shirtSize)
        {
            brand = shirtBrand;
            size = shirtSize;
        }

        public void DisplayInformation() //Method to display Shirt Details
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Shirt Details:");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Size: {size}");
        }
    }

    // Derived class PoloShirt inherits Shirt
    class PoloShirt : Shirt
    {
        //Additional property for the PoloShirt Class
        public bool HasCollar { get; set; }
        public bool SleeveLength { get; set; }

        //Constructor
        public PoloShirt (string shirtBrand, string shirtSize, bool hasCollar, bool sleeveLength) : base (shirtBrand, shirtSize) 
        {
            HasCollar = hasCollar;
            SleeveLength = sleeveLength;
        }

        //Method used to display PoloShirt details
        public void PoloShirtDetails()
        {
            base.DisplayInformation();
            Console.WriteLine($"Has Collar: {(HasCollar ? "Yes" : "No")}");

            Console.WriteLine($"Sleeve Length: {(SleeveLength ? "Short" : "Long")}");
        }
    }

    //Another derived class Tshirt inherits Shirt
    class Tshirt : Shirt
    {
        //Additional property for the Tshirt Class
        public string NeckType { get; set; } //"Round" or "V-neck"
        public bool HasPocket { get; set; }
    
        public Tshirt (string shirtBrand, string shirtSize, string neckType, bool hasPocket) : base (shirtBrand, shirtSize)
        {
            NeckType = neckType;
            HasPocket = hasPocket;
        }
    
        //Method used to display Tshirt details
        public void TShirtDetails()
        {
            base.DisplayInformation();
            Console.WriteLine($"Neck Type: {NeckType}");
            Console.WriteLine($"Has Pocket: {(HasPocket ? "Yes" : "No")}");
        }
    }
}
