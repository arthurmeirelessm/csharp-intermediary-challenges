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

            int[] listOfNumbers = new int[] { 2, 5, 63, 6, 4, 3, 4, 89, 32, 56 };
            challenge.FindMinMax(listOfNumbers);
        }
    }
}
