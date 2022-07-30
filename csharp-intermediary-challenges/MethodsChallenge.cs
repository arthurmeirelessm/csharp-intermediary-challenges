using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediary_challenges
{
    public class MethodsChallenge
    {
        //(1)
        public object FullNameMonth(int month)
        {
            if (month > 12)
            {
                return 0;
            }

            DateTime date = new DateTime(2022, month, 1);

            return date.ToString("MMMM");
        }

        //(2) 
        public bool FindMinMax(int[] listOfNumbers)
        {
            Array.Sort(listOfNumbers);
            if (listOfNumbers.Length < 2)
            {
                Console.WriteLine("This array must have more than two numbers");
                return false;
            }
            foreach (int number in listOfNumbers)
            {
                Console.WriteLine(number);
            }
            return true;
        }


        //(2)

    }
}
