using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_InheritanceWithConstructor
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Simple Inheritance

        static void Main(string[] args)
        {
            //Create an instance of the RegularStudent Class
            RegularStudent regularStudent = new RegularStudent("Monalesa Salipot", "BSIT", "IT306");
            
            //Display Regular Student Information
            Console.WriteLine("\n---- Regular Student ----\n");
            regularStudent.SectionEnrolled(); // Call method to display Regular Student Details

            //Create another instance for the IrregularStudent Class
            IrregularStudent irregularStudent = new IrregularStudent("Jane Ann Tabanas", "BSTM", "18 Units");

            //Display Irregular Student Information
            Console.WriteLine("\n---- Irregular Student ----\n");
            irregularStudent.EnrolledSemUnits();

            Console.ReadKey();
        }
    }
}
