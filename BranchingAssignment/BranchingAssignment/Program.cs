using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express!\n" +//intro conctanated to not have to write console multiple times.
                "Please follow the instructions below.\n" +
                "Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());// cast to int to save as variable to use later
            if (weight > 50)// The first branching statement to see if we will continue with the program
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");// our message if they cannot continue
            }
            else// the second par t of the first branching statement which continues the program
            {
                Console.WriteLine("Please enter the Package Width: ");// we ask for the next part of the program
                int width = Convert.ToInt32(Console.ReadLine());// we save the users answer in a variable to use later

                Console.WriteLine("Please enter the package height: ");// third request from user
                int height = Convert.ToInt32(Console.ReadLine());// cast again to use in variable

                Console.WriteLine("Please enter the package length: ");// last request from user
                int length = Convert.ToInt32(Console.ReadLine());//cast to int and save as variable

                int total = length * width * height * weight;// we get the total dimension from the box to see if it is too big to ship.
                decimal quote = total / 100m;// we divide the total by 100 for the quote and save this variable so we can use it in the branching statement.

                if (length + width + height > 50)// the second branching statement to see if the box is too big dimision wise.
                {
                    Console.WriteLine("Package too big to be shipped via package express. Have a good day.");// our statement if it is too big.
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is $" + quote);// we concatanate the string with the quote to give the shipping total.
                }
            }

        }
    }
}
