using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.IfandElse
{
    internal class EvenOrOdd
    {
        public void CheckOddEven()
        {
            Console.WriteLine("Program to check whether a given number is even or odd");
            int num, rem;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            rem = num % 2;
            if (rem == 0)
                Console.WriteLine("{0} is an Even number", num);
            else
                Console.WriteLine("{0} is an Odd number", num);
        }
    }
}
