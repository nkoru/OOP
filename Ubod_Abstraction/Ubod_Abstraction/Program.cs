using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PoloShirt polo = new PoloShirt("Bench", "Blue", 799.00, "Cotton");
            TShirt tshirt = new TShirt("Penshoppe", "White", 499.00, "Graphic Print");

            polo.DisplayInfo();
            Console.WriteLine($"Discounted Price (20% off): ₱{polo.DiscountPrice(20)}\n");

            tshirt.DisplayInfo();
            Console.WriteLine($"Discounted Price (15% off): ₱{tshirt.DiscountPrice(15)}");
        }
    }
}
