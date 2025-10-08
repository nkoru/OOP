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
            // Create instances of DressPants and CasualPants
            DressPants dress = new DressPants("Armani", "Charcoal", 3200.00, "Wool Blend");
            CasualPants casual = new CasualPants("Uniqlo", "Khaki", 1200.00, "Relaxed Fit");

            dress.DisplayInfo();
            dress.DiscountPrice(25);

            casual.DisplayInfo();
            casual.DiscountPrice(10);
    
            Console.ReadKey();
        }
    }
}
