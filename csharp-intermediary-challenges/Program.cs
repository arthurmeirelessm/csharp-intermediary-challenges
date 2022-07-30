using System;
using System.Collections.Generic;

namespace csharp_intermediary_challenges
{
    public class Program
    {
        static void Main(string[] args)
        {


            // (1) Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example,
            //if you're given 3 as input, your function should return

            MethodsChallenge challenge = new MethodsChallenge();
            Console.WriteLine(challenge.FullNameMonth(13));

            //----------------------------------------------------------------------------------------------------------------------

            //(2) Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

            int[] listOfNumbers1 = new int[] { 2, 3, 5, 6, 7, 34};
            Console.WriteLine(challenge.FindMinMax(listOfNumbers1));

            //-------------------------------------------------------------------------------------------------------------------------

            //(30) Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.


            int[] listOfNumbers2 = new int[] { 3, 5 , 2 };
            Console.WriteLine(challenge.AbsoluteSum(listOfNumbers2));

        }
    }
}
