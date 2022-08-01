using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediary_challenges
{
    public class AddToString
    {
        public Array arr { get; set; }

        public AddToString(Array arr)
        {
            this.arr = arr;
        }

        public override string ToString()
        {
            return "Array: " + arr.ToString();
          }

    }
}
