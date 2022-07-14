using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a try/catch block to handle exceptions if user inputs incorrectly
            try
            {
                //Ask for an input
                Console.WriteLine("Please enter the current day of the week.");
                string day = Console.ReadLine();//place the input in a string variable
                Enums.DaysOfTheWeek days = (Enums.DaysOfTheWeek)Enum.Parse(typeof(Enums.DaysOfTheWeek), day);//convert the string to enum varable days.
            }
            //our catch block cathces if there is an exceptions and throws an error message
            catch (Exception ex)
            {
                //Wrote our own message instead of the defualt message
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
