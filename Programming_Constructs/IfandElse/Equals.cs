using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.IfandElse
{
    internal class Equals
    {
        public void CheckEqualOrNot()
        {
            Console.WriteLine("Program to accept two integers and check whether they are equal or not");
            int a, b;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("{0} and {1} are equal", a, b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", a, b);
            }
        }
    }
}
