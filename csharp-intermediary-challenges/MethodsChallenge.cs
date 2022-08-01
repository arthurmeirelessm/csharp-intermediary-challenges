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
        public void FindMinMax(int[] listOfNumbers)
        {
            Array.Sort(listOfNumbers);
            foreach (int number in listOfNumbers)
            {
                Console.WriteLine(number);  
            }
        }


        //(3)

        public int AbsoluteSum(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }

        //(4)
        public object MultiplyByLength(int[] numbers)
        {
            var multiply = numbers.Select(x => x * numbers.Length);
            multiply.ToList().ForEach(Console.WriteLine);
            return numbers;
        }
    }
}
