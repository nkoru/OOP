using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Polymorphism
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Polymorphism

        static void Main(string[] args)
        {
            // Using polymorphism with base class reference
            Pants myPants;

            // Jeans instance assigned to Pants reference
            myPants = new Jeans()
            {
                Brand = "Beepop",
                Size = "26",
                FitType = "Baggy Fit"
            };

            myPants.DisplayInformation(); // Calls Jeans' overridden method

            // Sweatpants instance assigned to Pants reference
            myPants = new Sweatpants()
            {
                Brand = "Adidas",
                Size = "Medium",
                Material = "Cotton"
            };

            myPants.DisplayInformation(); // Calls Sweatpants' overridden method

            Console.ReadKey();
        }
    }
}

