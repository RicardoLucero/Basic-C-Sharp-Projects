using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    class Math
    {
        public static int MyMethod(int x)//the parameter is an int
        {
            int total = 50 + x;// the operation is addition to the input
            return total;// we return an int
        }

        public static int MyMethod(decimal y)//the parameter is a decimal but the method wants an int returned
        {
            int total = Convert.ToInt32(y) * 7;//we cast the parameter/argument to an int
            return total;// now we can return an int
        }

        public static int MyMethod(string z)//the parameter is a string but the method will return an int
        {
            int total = 500 - Convert.ToInt32(z);//the total var is an int so we cast the string to an int to work with it
            return total;// Return the int to the method
        }
    }
}
