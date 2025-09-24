using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IrregularStudent irregularStudent = new IrregularStudent(6000, 12, 1500);
            WorkingStudent workingStudent = new WorkingStudent(6000, 12500, 42000);

            double irregularStudentTF = irregularStudent.ComputeTuitionFee();
            double workingStudentTF = workingStudent.ComputeTuitionFee();

            Console.WriteLine("Irregular Student Tuition Fee: " + irregularStudentTF);
            Console.WriteLine("Working Student Tuition Fee: " + workingStudentTF);   
        }
    }
}
