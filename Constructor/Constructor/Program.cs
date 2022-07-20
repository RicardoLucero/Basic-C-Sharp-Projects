using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string appName = "Constructors";//create a constant of the app name Constructors
            Console.WriteLine("Welcome to the {0} app.", appName);// we do a string format with the constant
            Console.WriteLine("Please tell me your name?");// we ask for an input of the user
            var userName = Console.ReadLine();// place the input in a variable of var
            Console.WriteLine("Please tell me which city you are from.");
            var city = Console.ReadLine();
            User user = new User(userName, city);//place the varibles in the user method
        }
    }
}
