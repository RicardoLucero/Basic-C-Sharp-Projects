using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission
{
    static class StaticClass// declare the class to be static
    {
        public static void AddMethod(int x)//the method must have the static modifier since the class is static
        {
            int add = x + 99;// we add 99 to the input
            Console.WriteLine(x + " plus 99 equals: " + add);// we write to the console  to show the output of the method
        }
    }
}
