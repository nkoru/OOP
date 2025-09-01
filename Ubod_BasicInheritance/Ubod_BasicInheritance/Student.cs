using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_BasicInheritance
{
    internal class Student  //Base class
    {
        //Set properties for the Student Class
        public string Name { get; set; }
        public string Program { get; set; }

        public void BasicInfo()
        {            
            //Method to display Student Information
            Console.WriteLine($"Student: {Name}");
            Console.WriteLine($"Program: {Program}");
        }
    }

    // Derived class for Regular Student inherits Student
    class RegularStudent : Student
    {
        //Additional property for the Regular Student Class
        public string Section { get; set; }

        //Method used to display Regular Student details
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }

    //Derived class for Irregular Student inherites Student 
    class IrregularStudent : Student
    {
        //Additional property for the Irregular Student Class
        public string UnitsEnrolled { get; set; }

        //Method used to display Irregular Student details
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Unit/s Enrolled: {UnitsEnrolled}");
        }
    }
}

