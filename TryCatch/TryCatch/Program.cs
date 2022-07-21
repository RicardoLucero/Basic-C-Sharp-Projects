using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime todaysDate = DateTime.UtcNow;// get the current UTC date and time

                bool validanswer = false;
                int age = 1;
                while (!validanswer)
                {
                    Console.WriteLine("What is your age? ");//ask the user for their age
                    validanswer = int.TryParse(Console.ReadLine(), out age);//cast thier input to an integer
                    if (!validanswer) Console.WriteLine("Please no negative numbers, zero, or decimals.");
                }
                
                int yearsindays = age * 365;//get thier age in days
                TimeSpan duration = new TimeSpan(yearsindays, 0, 0, 0);//add the years in days to the timespan
                DateTime diff = todaysDate.Subtract(duration);//subtract todays date by the amount of years we have calculated with years in days
                Console.WriteLine("Your birth year is in: " + diff);// display the year that they would have been born in
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please do not enter any negative numbers.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please do not enter zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
