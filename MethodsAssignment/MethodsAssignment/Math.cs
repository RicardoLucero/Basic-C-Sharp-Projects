using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Math
    {
        //we make the method public to use it in the main program
        //also make it static to make it return an integer
        public static int MultiplyMethod(int number)//the parameter is going to be an int variable
        {
            int total = 9 * number;// we multiply the variable by 9 to do the operation
            Console.WriteLine(9 + " times " + number + " equals: " + total);
            return total;//we return the interger total
        }//we do the same for the divide method
        public static int DivideMethod(int number)
        {
            int total = 365 / number;
            Console.WriteLine(12 + " divided by " + number + " equals: " + total);
            return total;
        }//same goes for add method
        public static int AddMethod(int number)
        {
            int total = 50 + number;
            Console.WriteLine(50 + " plus " + number + " equals: " + total);
            return total;
        }
    }
}