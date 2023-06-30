using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.IfandElse
{
    internal class EligibleAge
    {
        public void CandidateAge()
        {
            Console.WriteLine("Program to read the age of a candidate and determine whether it is eligible for casting his/her own vote in c#");
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
                Console.WriteLine("Sorry, you are not eligible to caste your vote");
            else
                Console.WriteLine("Congratulations! You are eligible for casting your vote");
        }
    }
}
