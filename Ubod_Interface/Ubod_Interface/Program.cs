using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of PoloShirt and TShirt
            IShirtDetails polo = new PoloShirt("Lacoste", "White", 2500.00, "Cotton");
            IShirtDetails tee = new TShirt("Nike", "Black", 1500.00, "Medium");

            // Displaying information and calculating discounts
            polo.DisplayInfo();
            polo.CalculateDiscount(10);

            tee.DisplayInfo();
            tee.CalculateDiscount(15);

            Console.ReadKey();
        }
    }
}
