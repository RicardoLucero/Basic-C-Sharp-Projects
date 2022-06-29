using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "Welcome", "Hi", "Hello there", "Hey", "What\'s up?" };// Used the shortened version of writing a string array.
        int[] numArray = { 47, 28, 31, 420, 69 };// Also used shortened version of instantiating an array
        List<string> stringList = new List<string>();// Instantiate a string list and named it stringList
        stringList.Add("End");// Adding to the list so there will be something for the user to pick for the app.
        stringList.Add("Goodbye");
        stringList.Add("See Ya");
        stringList.Add("Later");
        stringList.Add("Peace");

        Console.WriteLine("Please pick an index number from 0 through 4");// Ask the user for an input
        int input = Convert.ToInt32(Console.ReadLine());// Cast the input to a number as that will correlate to the index of the array.
        bool correctnum = false;// We set a bool variable to run a do while loop.

        do
        {
            switch (input)// the switch is taking the input to give the response to the user that we want
                // while also control what they can input. If they give us an input we do not want then 
                // they are greeted with an error message and coerced to correct their input.
            {
                case 0:
                    Console.WriteLine(stringArray[input]);// In order to display the item that is in the array index that they chose
                    // we write to the console the string array and for the index we put the casted input so it will match with what they entered.
                    correctnum = true;// Set the bool to true to end the loop.
                    break;
                case 1:
                    Console.WriteLine(stringArray[input]);
                    correctnum = true;
                    break;
                case 2:
                    Console.WriteLine(stringArray[input]);
                    correctnum = true;
                    break;
                case 3:
                    Console.WriteLine(stringArray[input]);
                    correctnum = true;
                    break;
                case 4:
                    Console.WriteLine(stringArray[input]);
                    correctnum = true;
                    break;
                default:// The defualt will handle if they give us any answer other then the amount of items in the array.
                    Console.WriteLine("You did not choose an index that is in the array.\n" +
                        "Please try again.");
                    input = Convert.ToInt32(Console.ReadLine());// The input variable is ready to recieve another input to do the loop again.
                    break;
            }
        }
        while (!correctnum);

        Console.WriteLine("Once again, Please pick an index number from 0 through 4");// We now move on to the second question to the user.
        int number = Convert.ToInt32(Console.ReadLine());
        bool correctnum2 = false;// Once again we create a bool variable to control the do while loop.

        do// Used a do while loop because if the user gives a correct input the first time the loop will be skipped entirely.
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine(numArray[number]);
                    correctnum2 = true;
                    break;
                case 1:
                    Console.WriteLine(numArray[number]);
                    correctnum2 = true;
                    break;
                case 2:
                    Console.WriteLine(numArray[number]);
                    correctnum2 = true;
                    break;
                case 3:
                    Console.WriteLine(numArray[number]);
                    correctnum2 = true;
                    break;
                case 4:
                    Console.WriteLine(numArray[number]);
                    correctnum2 = true;
                    break;
                default:
                    Console.WriteLine("You did not choose an index that is in the array.\n" +
                        "Please try again.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!correctnum2);

        Console.WriteLine("Last time, Please pick an index number from 0 through 4");// Final question to user for input
        int listnum = Convert.ToInt32(Console.ReadLine());
        bool correctnum3 = false;// final bool variable created for loop

        do
        {
            switch (listnum)//this time we are using a List
            {
                case 0:
                    Console.WriteLine(stringList[listnum]);
                    correctnum3 = true;
                    break;
                case 1:
                    Console.WriteLine(stringList[listnum]);
                    correctnum3 = true;
                    break;
                case 2:
                    Console.WriteLine(stringList[listnum]);
                    correctnum3 = true;
                    break;
                case 3:
                    Console.WriteLine(stringList[listnum]);
                    correctnum3 = true;
                    break;
                case 4:
                    Console.WriteLine(stringList[listnum]);
                    correctnum3 = true;
                    break;
                default:
                    Console.WriteLine("You did not choose an index that is in the array.\n" +
                        "Please try again.");
                    listnum = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!correctnum3);
        Console.ReadLine();
    }
}
