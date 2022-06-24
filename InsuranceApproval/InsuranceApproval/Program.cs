using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Insurance approval \n" +
                "What is your Age?");
            int age = Convert.ToInt32(Console.ReadLine());// The answer we get must be casted to int so we can compare it later in the program.
            Console.WriteLine("Have you ever had a DUI?" +
                "\nPlease enter true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine());// Cast the answer to a boolean also for comparison later.
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());// Cast to int again for comparison.

            //Now we will write the qualifications to compare our answers to.
            int ageLimit = 15;
            bool haveDuis = false;
            int mostTickets = 3;

            Console.WriteLine("Qualified?:");
            Console.WriteLine(age >= ageLimit && dui == haveDuis && tickets <= mostTickets);
            //Here we evaluated and compared the answer to the qualifications, we asked
            //if the age is over the age limit, AND if they have ever had a dui, AND if they have under enough speeding tickets to qualify for insurance.
        }
    }
}
