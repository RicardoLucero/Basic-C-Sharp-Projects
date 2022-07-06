using System;
using System.Collections.Generic;

namespace StringAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start a try block of code
            try
            {
                List<int> numbersList = new List<int>() { 20, 14, 22, 40, 32, 47 };// Initializing a new int list
                Console.WriteLine("Please give a number.");
                int firstNumber = Convert.ToInt32(Console.ReadLine());// the input is casted to an int to use in a mathmatical function

                // We use a loop to divide the list of numbers by the input given
                foreach (int number in numbersList)// We loop though the list using a for each loop
                {
                    int totalNumber = number / firstNumber;// we made a third variable to hold the total from the division of the input from the list items
                    Console.WriteLine(number + " divided by " + firstNumber + " equals " + totalNumber + ".");// Present the total of the division as we loop interate through the list
                }
                Console.ReadLine();
            }
            //begin our catch blocks
            catch (DivideByZeroException ex)// Catch an exception that is caused by trying to divide by zero
            {// Used a custom message as opposed to the default message for the exception.
                Console.WriteLine("Please enter another number either than zero.");
            }
            catch (FormatException ex)// Catches an exception caused by a wrong data format being inputed. 
            {
                Console.WriteLine("Please enter a whole number.");
            }
            finally// Is used to continue after the catch has been executed instead of letting the program exit
            {
                Console.WriteLine("We will continue...");
                Console.ReadLine();
            }

        }
    }
}
