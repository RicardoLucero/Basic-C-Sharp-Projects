using System;


namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to my app the current time is: " + DateTime.Now);//print to the console the current time
            Console.WriteLine("Please input a number.");//ask for input from the user
            int x = Convert.ToInt32(Console.ReadLine());// cast the input to an integer
            DateTime currentTime = DateTime.Now.AddHours(x);//addthe input to the current time
            Console.WriteLine("Your number " + x + " will be added to the time to let you know what time it will be. " + currentTime);// let the user know what time it will be with their input
            
        }
    }
}
