using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_EncapsulationUserInput
{
    internal class Shirt
    {
        //Declare properties for the Shirt class
        public string Brand { get; set; }
        public string Size { get; set; }


        //Method to display the Shirt information
        public void DisplayInformation()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Shirt Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}
