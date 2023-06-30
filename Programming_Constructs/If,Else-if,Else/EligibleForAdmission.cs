using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs.If_Else_if_Else
{
    internal class EligibleForAdmission
    {
        public void Eligibility()
        {
            Console.WriteLine("Program to find the eligibility of admission for a professional course c#");
            int phy, chem, maths;
            Console.WriteLine("Enter marks of Physics");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Chemistry");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Maths");
            maths = Convert.ToInt32(Console.ReadLine());

            int totalMarks = phy + chem + maths;
            if (maths >= 65 && phy >= 55 && chem >= 50 && totalMarks >= 180)
                Console.WriteLine("The candidate is eligible for admission");
            else if (maths == 100 && (phy + chem) >= 140)
                Console.WriteLine("The candidate is eligible for admission");
            else
                Console.WriteLine("The candidate is not eligible for admission");
        }
    }
}
