using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_PropertiesAndEncapsulation
{
    internal class Program
    {
        //Name: Beatrice Nicole Ubod
        //Section: IT306

        //Exercise: Basics on Encapsulation

        static void Main(string[] args)
        {
            //Instantiate the Shirt class
            Shirt myShirt = new Shirt();

            //Set the properties of the Shirt class fields
            myShirt.Brand = "Uniqlo";
            myShirt.Size = "Small";

            //Display the Shirt information
            myShirt.DisplayInformation();

            Console.ReadKey();
        }
    }
    }
}
