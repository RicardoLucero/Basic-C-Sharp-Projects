using System;

namespace MathConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are setting up some variables to do some math with the numbers that are given to us from the user.
            int product = 50;
            int add = 25;
            double quotient = 12.5;
            int greater = 50;

            Console.WriteLine("Welcome to the Math application.\nYou will be asked to input your numbers and \nThe console will show your your asnwer.");
            Console.WriteLine("Please input a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());//console.readline are always given to us as a string so we cast it as an int
            long productTotal = num1 * product;//here we use the casted int and multiply it by our variable
            Console.WriteLine("Your number times 50 equals: " + productTotal.ToString());

            Console.WriteLine("Please input your next number.");
            int num2 = Convert.ToInt32(Console.ReadLine());// once again we have to cast to an int to do the math
            long addTotal = num2 + add;//our add variable is used to add to the second number
            Console.WriteLine("Your second number plus 25 equals: " + addTotal.ToString());

            Console.WriteLine("Please input your third number.");
            int num3 = Convert.ToInt32(Console.ReadLine());//we convert to use it with our division
            double quotientTotal = num3 / quotient;// we use a double for the data type to hold the remainder in the decimals.
            Console.WriteLine("3rd Number divided by 12.5 equals: " + quotientTotal.ToString());//else we will round down as the computer does.

            Console.WriteLine("Please give your fourth number.");
            int num4 = Convert.ToInt32(Console.ReadLine());// we cast to use it in a comparison
            bool isGreat = num4 > greater;// our variable has to be a bool since it will be compared to see if its ture or false
            Console.WriteLine("Is your number greater then 50? \n" + isGreat);

            Console.WriteLine("Last number please.");
            int num5 = Convert.ToInt32(Console.ReadLine());// we cast to use it in a divison function
            float modulous = num5 % 7;//our variable is a float to get the remainder
            Console.WriteLine(modulous);//we use the modulous operator to find out the remainder.

        }
    }
}
