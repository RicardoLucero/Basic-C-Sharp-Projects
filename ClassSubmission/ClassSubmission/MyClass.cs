using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission
{
    class MyClass
    {
        public void MyMethod(int x)//method only asks for one parameter
        {
            int total = x / 2;// divide the input by 2
            Console.WriteLine(x + " divided by 2 equals: " + total);// write to the console to show the output of the method
            //before passing control back to main program
        }

        public void TheMethod(int x, out string message)//method ask for two parameters one is an out parameter
        {
            int multiply = x * 9;// user will not know what we are doing to their input
            message = "Your returned total is: " + multiply;//this variable will be outputed to the user
            Console.WriteLine(message);//we write it to the console
        }

        public void MyMethod(int x, int y)//overloading mehtod with two parameters as the first method only asked for one
        {
            int equation = x * 3 / y + 200;
            Console.WriteLine(x + " times 3 divided by " + y + " plus 200 equal: " + equation);//write to the console the answer
        }
    }
}
