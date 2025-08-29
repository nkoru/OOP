using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ubod_COConstructorUserInput
{
    internal class Shoes
    {
        // declaration of the fields
        public string brand, color; public int size;

        public Shoes(string aBrand, string aColor, int aSize) // parameterized constructor
        {
            brand = aBrand;
            color = aColor;
            size = aSize;
        }

        // method used to display its details
        public void DisplayShoeDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("\t Shoe Details ----"); Console.WriteLine("\n\t/Shoe Brand: " + brand); Console.WriteLine("\tShoe Color: " + color); Console.WriteLine("\tShoe Size: * + size");

        }
    }
}
