using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give a number.");// Ask for input
            int input = Convert.ToInt32(Console.ReadLine());// Cast to int to work with our method
            int total = Math.MyMethod(input);// Pass int input to the method 
            Console.WriteLine(input + " plus " + 50 + " equals " + total);// Write the total to the console
            Console.ReadLine();

            Console.WriteLine("Please give a decimal number.");// Ask for a decimal input this time
            decimal input2 = Convert.ToDecimal(Console.ReadLine());// Cast this time to a decimal
            int total2 = Math.MyMethod(input2);// the variable is an int since we return an int from the method
            Console.WriteLine("You answer will be rounded to a whole number :" + total2);
            Console.ReadLine();

            Console.WriteLine("Please give a number.");// The input askk for a number but we take it as a string
            string input3 = Console.ReadLine();// We take the number as a string
            int total3 = Math.MyMethod(input3);// Our method returns an int
            Console.WriteLine(input3 + " minus " + 500 + " equals " + total3);
            Console.ReadLine();
        }
    }
}
