using System;
using System.Collections.Generic;

namespace csharp_intermediary_challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            MethodsChallenge challenge = new MethodsChallenge();

            // (1) Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example,
            //if you're given 3 as input, your function should return


            Console.WriteLine(challenge.FullNameMonth(13));
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------------

            //(2) Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

            int[] listOfNumbers1 = new int[] { 4, 6, 8, 4, 67 ,63, 87, 97,32, 1};
            challenge.FindMinMax(listOfNumbers1);
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------------------------------------

            //(3) Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.

            int[] listOfNumbers2 = new int[] { 3, 5 , 2 };
            Console.WriteLine(challenge.AbsoluteSum(listOfNumbers2));
            Console.WriteLine();

            //(4) Create a function to multiply all of the values in an array by the amount of values in the given array

            int[] listOfNumbers3 = new int[] { 3, 5, 5, 7 };
            challenge.MultiplyByLength(listOfNumbers3);
            
        }
    }
}
