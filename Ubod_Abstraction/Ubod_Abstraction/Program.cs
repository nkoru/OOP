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
            // Create objects from derived classes
            SchoolBag sBag = new SchoolBag("JanSport", "Blue", 1500, 4);
            TravelBag tBag = new TravelBag("Samsonite", "Black", 4500, 35);

            // Demonstrate polymorphism using overridden methods
            sBag.DisplayDetails();
            sBag.CalculateDiscount(10);
            sBag.Carry();

            Console.WriteLine("-------------------------------");

            tBag.DisplayDetails();
            tBag.CalculateDiscount(15);
            tBag.Carry();

            Console.ReadLine();
        }
    }
}
