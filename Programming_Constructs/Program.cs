using Programming_Constructs.Switch_Case;
using System;

namespace Programming_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one from below options");
            Console.WriteLine("1.Weekday Name\n2.Arithmatic Operations");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    WeekDay weekDay = new WeekDay();
                    weekDay.WeekNum();
                    break;
                case 2:
                    ArithmaticOperations operations = new ArithmaticOperations();
                    operations.Operations();
                    break;
            }
        }
    }
}