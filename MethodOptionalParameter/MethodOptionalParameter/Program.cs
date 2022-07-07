using System;

namespace MethodOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers, but 1 at a time." +//We tell the user we  want two inputs
                "\nEnter the first number now.");//Now we ask for one at a time
            string x = Console.ReadLine();// the first input is put into the variable x
            Console.WriteLine("The Second number is optional.");// we now ask for the second input, we let them know its optional
            string y = Console.ReadLine();// the second input is put into the the variable y
            if ( y == "") //we use an if statement to get the optional statement to work with an empty 2nd argument
            {
                int total = Optional.MyMethod(x);// this method will use the defualt paramenter
                Console.WriteLine(total);
            }
            else // else is used to use the optional parameter
            {
                int total = Optional.MyMethod(x, y);// we call the method and pass the arguments over
                Console.WriteLine(total);
            }
        }
    }
}
