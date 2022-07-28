using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediary_challenges
{
    public class MethodsChallenge
    {
        //(1)
       public string FullNameMonth (int month)
        {
            DateTime date = new DateTime(2022, month, 1);

            return date.ToString("MMMM");
        }

    }
}
