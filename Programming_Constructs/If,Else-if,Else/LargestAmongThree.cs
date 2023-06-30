using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.If_Else_if_Else
{
    internal class LargestAmongThree
    {
        public void LargestOfThree()
        {
            Console.WriteLine("Program to find the largest of three numbers in c#");
            int a, b, c;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("1st number is greatest among three");
                else
                    Console.WriteLine("3rd number is greatest among three");
            }
            else if (b > c)
                Console.WriteLine("2nd number is greatest among three");
            else
                Console.WriteLine("3rd number is greatest among three");
        }
    }
}
