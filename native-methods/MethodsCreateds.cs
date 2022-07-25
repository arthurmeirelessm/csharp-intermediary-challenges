using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace native_methods
{
    public class MethodsCreateds
    {

        public void ArrayPush<T>(ref T[] table, object value)
        {
            Array.Resize(ref table, table.Length + 1);
            table.SetValue(value, table.Length -1);
        }
    }
}
