using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicInheritance
{
    internal class Program
    {
        // Name: Beatrice Nicole Ubod
        // Section: IT306
        // Exercise: Simple Inheritance

        static void Main(string[] args)
        {
            RegularStudent regularStudent = new RegularStudent //Create an instance of the RegularStudent Class
            {
                Name = "Monalesa Salipot",
                Program = "BSIT",
                Section = "IT306"
            };
            Console.WriteLine("\n---- Regular Student ----\n"); 
            regularStudent.BasicInfo(); // Call inherited method to display Student Info
            regularStudent.SectionEnrolled(); // Call method to display Regular Student Details

            IrregularStudent irregularStudent = new IrregularStudent //Create another instance for the IrregularStudent Class
            {
                Name = "Jane Ann Tabanas",
                Program = "BSTM",
                UnitsEnrolled = "18 Units"
            };
            Console.WriteLine("\n---- Irregular Student ----\n");
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();

            Console.ReadKey();
        }
    }
}
