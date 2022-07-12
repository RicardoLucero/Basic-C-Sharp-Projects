using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Method = new MyClass();// instantiate the class

            Console.WriteLine("Please input a number.");//ask for an input
            int x = Convert.ToInt32(Console.ReadLine());// cast to an integer
            Method.MyMethod(x);//we call the method and pass in the argument
            Console.ReadLine();

            string message = "";//we have a message so we can run our out parameter for our second method
            Console.WriteLine("Your number will now be run on another equation.");
            Method.TheMethod(x, out message);//we call the method and pass in the two arguments
            Console.ReadLine();

            Console.WriteLine("Please input a  second number.");// ask for a second input
            int y = Convert.ToInt32(Console.ReadLine());// cast to integer as well
            Method.MyMethod(x, y);// we call the method passing the two arugments
            Console.ReadLine();

            StaticClass.AddMethod(x);// we call our method from the static class
        }
    }
}
