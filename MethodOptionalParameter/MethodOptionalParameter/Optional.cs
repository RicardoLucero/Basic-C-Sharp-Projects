using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOptionalParameter
{
    class Optional
    {
        public int MyMethod(int x, int y = 6)//the method is asking for two parameters and one is an optional parameter
        {
            int total = y * x;// we will multiply the two together
            return total;//we return the total.
        }
    }
}
