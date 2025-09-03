using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_InheritanceWithConstructor
{
    internal class Student  //Base class
    {
        //Set fields for the Student Class
        public string Name;
        public string Program;

        public Student (string name, string program)
        {
            Name = name;
            Program = program;
        }

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
        public string Section;

        //Constructor
        public RegularStudent (string name, string program, string section) : base (name, program)
        {
            Section = section;
        }

        //Method used to display Regular Student details
        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine($"Section: {Section}");
        }

    }

    //Derived class for Irregular Student inherites Student 
    class IrregularStudent : Student
    {
        //Additional property for the Irregular Student Class
        public string UnitsEnrolled;

        //Constructor
        public IrregularStudent(string name, string program, string unitsEnrolled) : base(name, program)
        {
            UnitsEnrolled = unitsEnrolled;
        }

        //Method used to display Irregular Student details
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine($"Unit/s Enrolled: {UnitsEnrolled}");
        }
    }
}
