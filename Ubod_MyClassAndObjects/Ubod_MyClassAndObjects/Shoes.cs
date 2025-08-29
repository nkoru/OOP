using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_MyClassAndObjects
{
    internal class Shoes
    {
        //class members
        public string brand, color;
        public int size;

        //method to display
        public void DisplayInfo()
        {
            Console.WriteLine("\nShoe Brand: " + brand +
                            "\nSize: " + size +
                            "\nColor: " + color);
        }
        
    }
}
