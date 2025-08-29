using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_MyClassAndObjects
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise Title: Create a Class

        static void Main(string[] args)
        {
            Shoes shoes1 = new Shoes(); //instantiation of the object
            Shoes shoes2 = new Shoes();

            //initialization of fields
            shoes1.brand = "Timberlands"; shoes1.size = 10;
            shoes1.color = "Brown";
            shoes2.brand = "Dr. Martens Loafers";
            shoes2.size = 8;
            shoes2.color = "Black/Red";

            //display
            Console.WriteLine("I am an avid fan of collecting shoes and these are my favorites.");

            //calling of the method
            shoes1.DisplayInfo(); 
            shoes2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
