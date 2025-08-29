using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubod_CaO
{
    internal class Person
    {
        public string name;
        public int age;
        public string gender;

        public void Greet()
        {
            Console.Write("\t\t\tGood day, everyone!" + "\n\tHi, my name is " + name +  "\n\t\t would like to identify myself as" 
                                            + gender + "and I am" + age + "years of age.");
        }
    }
}
