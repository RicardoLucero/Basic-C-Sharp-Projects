using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opening to daily report
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // First question to report is a string variable
            Console.WriteLine("What is your name?");
            // we create a string variable yourName to hold the data we will get from the student.
            string yourName = Console.ReadLine();

            // Second question is another string variable
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Third queston is a short number variable
            Console.WriteLine("What page number?");
            //pageNumber will be given to us as a string
            string pageNumber = Console.ReadLine();
            //will use casting to convert it into an int
            short pageNum = Convert.ToInt16(pageNumber);

            // Fourth question is a bool variable
            Console.WriteLine("Do you need help with anything?\nPlease answer \"true\" or \"false.\"");
            string askHelp = Console.ReadLine();
            // Casting to a bool value from a string
            bool needHelp = Convert.ToBoolean(askHelp);

            // Fifth question is a string variable
            Console.WriteLine("Were there any positive experiences you\'d like to share?\nPlease give specifics.");
            string yourExp = Console.ReadLine();

            // Sixth question is  another string
            Console.WriteLine("Is there any other feedback you\'d like to provide?\nPlease be specific.");
            string feedBack = Console.ReadLine();

            // Seventh question is an Integer
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            // Casting the response from string to int
            short studyHrs = Convert.ToInt16(studyHours);

            // Closing statement
            Console.WriteLine("Thank you for your answers.\nAn Instructor will respond to this shortly.\nHave a great day!\nThis is the end of the program");

        }
    }
}
