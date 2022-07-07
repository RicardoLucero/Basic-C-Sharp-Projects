using System;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //We ask the user for an input
            Console.WriteLine("Please enter a number to do some mathmatical operations with.");
            int number = Convert.ToInt32(Console.ReadLine());//cast the input to an int to work some math operations with
            Console.WriteLine(Math.MultiplyMethod(number));//this is how we call the method and print it to the console
            Console.ReadLine();//we use a readline in between to give the user time to read what the method did to their input
            Console.WriteLine(Math.DivideMethod(number));
            Console.ReadLine();
            Console.WriteLine(Math.AddMethod(number));
            Console.ReadLine();
        }
    }
}
