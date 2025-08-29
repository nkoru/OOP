using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_COConstructorUserInput
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise Title: User Input with Constructor

        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            // prompt to let the users know what is the program all about

            Console.WriteLine("\tshis program will ask you about your shoe collection/s");
            Console.Write("\nEnter the brand of your shoes: "); 
            string aBrand = Console.ReadLine();

            Console.Write("Enter the color of your shoes: "); 
            string aColor = Console.ReadLine();

            Console.Write("Enter the size of your shoes: "); 
            int aSize = int.Parse(Console.ReadLine());

            // instantiation of the class object
            Shoes shoes1 = new Shoes(aBrand, aColor, aSize);

            // calling of the method to display
            shoes1. DisplayShoeDetails();

            // input another shoe details
            Console.Write("\nDo you want to add more (y/n)? "); 
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'y')
            {
                goto Main;
            }
            else if (ans == 'n')
            {
                return;
            }
        }
    }
}
