using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_PropertiesAndEncapsulation
{
    internal class Shirt
    {
        //Declare properties for the Shirt class
        private string brand;
        private string size;

        //Set properties for the Shirt class fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        //Method to display the Shirt information
        public void DisplayInformation()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Size: {size}");
        }
    }
}
