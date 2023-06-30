using System;
using Programming_Constructs.IfandElse;

namespace Programming_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one from below options");
            Console.WriteLine("1.Equal or not\n2.Even or Odd\n3.Eligible Age");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Equals eq = new Equals();
                    eq.CheckEqualOrNot();
                    break;
                case 2:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.CheckOddEven();
                    break;
                case 3:
                    EligibleAge age = new EligibleAge();
                    age.CandidateAge();
                    break;
            }
        }
    }
}