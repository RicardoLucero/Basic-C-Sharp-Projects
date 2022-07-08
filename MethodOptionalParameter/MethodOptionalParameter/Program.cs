using System;

namespace MethodOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Optional myObj = new Optional();

            Console.WriteLine("Please enter 2 numbers, but 1 at a time." +//We tell the user we  want two inputs
                "\nEnter the first number now.");//Now we ask for one at a time
            int x = Convert.ToInt32(Console.ReadLine());// the first input is put into the variable x
            Console.WriteLine("The Second number is optional." +
                "\n if no number is wanted please enter zero.");// we now ask for the second input, we let them know its optional
            int y = Convert.ToInt32(Console.ReadLine());// the second input is put into the the variable y
            if ( y == 0) //we use an if statement to get the optional statement to work with an empty 2nd argument
            {
                int total = myObj.MyMethod(x);// this method will use the defualt paramenter
                Console.WriteLine(total);
            }
            else // else is used to use the optional parameter
            {
                int total = myObj.MyMethod(x, y);// we call the method and pass the arguments over
                Console.WriteLine(total);
            }
        }
    }
}
