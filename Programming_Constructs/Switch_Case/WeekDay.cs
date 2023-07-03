using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.Switch_Case
{
    internal class WeekDay
    {
        public void WeekNum()
        {
            Console.WriteLine("Program to take user input as weekday number to calculate the weekday name in c#");
            Console.WriteLine("Enter number between (1-7)");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("It's SUNDAY");
                    break;
                case 2:
                    Console.WriteLine("It's MONDAY");
                    break;
                case 3:
                    Console.WriteLine("It's TUESDAY");
                    break;
                case 4:
                    Console.WriteLine("It's WEDNESDAY");
                    break;
                case 5:
                    Console.WriteLine("It's THURSDAY");
                    break;
                case 6:
                    Console.WriteLine("It's FRIDAY");
                    break;
                case 7:
                    Console.WriteLine("It's SATURDAY");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
