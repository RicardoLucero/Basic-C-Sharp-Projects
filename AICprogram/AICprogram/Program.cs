using System;

namespace AICprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program" + //Concatanating strings with newlines to use one WriteLine instead of typing it 3 times.
                "\nPerson 1" +
                "\nHourly Rate?");
            int hourly1 = Convert.ToInt32(Console.ReadLine());// Cast to an integer since ReadLines are always given as a string
            Console.WriteLine("Hours Worked Per Week?");
            int hrswrkd1 = Convert.ToInt32(Console.ReadLine());// Cast again to an integer to work with it using math
            Console.WriteLine("Person 2" +// Repeated again for the person 2
                "\n Hourly Rate?");
            int hourly2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week?");
            int hrswrkd2 = Convert.ToInt32(Console.ReadLine());

            int weekly1 = hourly1 * hrswrkd1;// Create a variable to hold the product of hourly rate and hours worked
            int weekly2 = hourly2 * hrswrkd2;
            double annual1 = weekly1 * 52;// Create another variable to hold product of weekly pay and weeks in a year
            double annual2 = weekly2 * 52;// this is how we get the gross annual Salary 

            Console.WriteLine("Annual Salary Of Person 1: \n" + annual1.ToString());// Concatanating the Variable of annual after casting it to a string
            Console.WriteLine("Annual Salary Of Person 2: \n" + annual2.ToString());
            bool makeMore = annual1 > annual2;// Create a bool variable to compare the two annual salaries
            Console.WriteLine("Does Persone 1 Make More Money Then Person 2? \n" + makeMore);// Concatanate the bool variable to string
        }
    }
}
