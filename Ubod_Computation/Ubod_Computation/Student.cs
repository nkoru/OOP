using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_Computation
{
    class Student
    {
        public double MiscellaneousFee { get; set; }

        public Student(double miscellaneousFee)
        {
            MiscellaneousFee = miscellaneousFee;
        }

    public virtual double ComputeTuitionFee()
        {
            return MiscellaneousFee;
        }
    }

    class IrregularStudent : Student
    {
        public int NumberOfUnits {  get; set; }
        public double RatePerUnit { get; set; }

        public IrregularStudent(double miscellaneousFee, int numberOfUnit, double ratePerUnit) : base(miscellaneousFee)
        {
            NumberOfUnits = numberOfUnit;
            RatePerUnit = ratePerUnit;
        }

    public override double ComputeTuitionFee()
        {
            double TuitionFee = NumberOfUnits * RatePerUnit;
            return TuitionFee + MiscellaneousFee;
        }
    }

    class WorkingStudent : Student
    {
        public double TuitionFeeDiscount { get; set; }
        public double BaseTuitionFee {  get; set; }

        public WorkingStudent(double miscellaneousFee, double tuitionFeeDiscount, double baseTuitionFee) : base(miscellaneousFee)
        {
            TuitionFeeDiscount = tuitionFeeDiscount;
            BaseTuitionFee = baseTuitionFee;    
        }

        public override double ComputeTuitionFee()
        {
            double tuitionFee = BaseTuitionFee - TuitionFeeDiscount;
            return tuitionFee + MiscellaneousFee;
        }
    }
}

