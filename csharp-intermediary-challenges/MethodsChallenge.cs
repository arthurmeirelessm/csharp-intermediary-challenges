﻿using System;
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
        public object FindMinMax(int[] listOfNumbers)
        {
            Array.Sort(listOfNumbers);
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
               
                    return listOfNumbers.ToList();
           
            }
            return null;
        }   

        //(2)

    }
}
