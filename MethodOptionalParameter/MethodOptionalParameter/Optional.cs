using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOptionalParameter
{
    class Optional
    {
        public static int MyMethod(string x, string y = "6")//the method is asking for two parameters and one is an optional parameter
        {
            int total = Convert.ToInt32(y) * Convert.ToInt32(x);// we will multiply the two together
            return total;//we return the total.
        }
    }
}
