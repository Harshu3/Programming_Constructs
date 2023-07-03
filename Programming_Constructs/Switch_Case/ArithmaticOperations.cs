using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.Switch_Case
{
    internal class ArithmaticOperations
    {
        public void Operations()
        {
            Console.WriteLine("Program to take 2 numbers as user input and perform arithmetic operations on it.i.e Addition, Subtraction, Multiplication and Division using switch Case in c#");
            Console.WriteLine("Enter 1st number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose any one operation from below");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, a + b);
                    break;
                case 2:
                    Console.WriteLine("Difference of {0} and {1} is: {2}", a, b, a - b);
                    break;
                case 3:
                    Console.WriteLine("Multiplication of {0} and {1} is: {2}", a, b, a * b);
                    break;
                case 4:
                    Console.WriteLine("Division of {0} and {1} is: {2}", a, b, a / b);
                    break;
            }
        }
    }
}
