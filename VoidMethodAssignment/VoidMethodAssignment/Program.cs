using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers myNumbers = new Numbers();// Instantiate the class.

            Console.WriteLine("please give two numbers.\n" +//we ask for input of two numbers for the arguments.
                "Enter the first number.");
            int x = Convert.ToInt32(Console.ReadLine());//cast the input to int.
            Console.WriteLine("Enter the second number.");
            int y = Convert.ToInt32(Console.ReadLine());//cast the second input to int.
            Numbers.MyMethod(firstNum:y, secondNum:x);// calling the method and naming the parameters.
        }
    }
}
