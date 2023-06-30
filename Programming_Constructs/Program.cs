using System;
using Programming_Constructs.If_Else_if_Else;

namespace Programming_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one from below options");
            Console.WriteLine("1.Largest among three\n2.Eligible for admission");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LargestAmongThree three = new LargestAmongThree();
                    three.LargestOfThree();
                    break;
                case 2:
                    EligibleForAdmission eligible = new EligibleForAdmission();
                    eligible.Eligibility();
                    break;
            }
        }
    }
}