using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] wordArray = { "Cool", "Happy", "Tubular", "Radical", "Awesome" };// Initializing a string array

        Console.WriteLine("Hello please enter a word.");
        string newWord = Console.ReadLine();

        for (int i = 0; i < wordArray.Length; i++)// For loop to iterate through array
        {
            wordArray[i] += newWord;// as we iterate throug the list each item is concatenated with the input
        }

        for (int j = 0; j < wordArray.Length; j++)// we loop again to print out the array with the input added to the origianl array
        {
            Console.WriteLine(wordArray[j]);
        }
        Console.ReadLine();

        Console.WriteLine("Give me a number from 1 - 10?");// ask the user for a number in a set range
        int givenNumber = Convert.ToInt32(Console.ReadLine());// cast the input to an integer

        while (givenNumber < 11)// the while loop states that while the input is less then 11 it will run again
        {
            Console.WriteLine("Your number is " + givenNumber + ".");// we write to the console the input given to us through each iteration
            // increment the value of givenNumber by 1 for the next iteration
            givenNumber++;
            //corrected the infinite to increment instead of decrement where it would never meet the requirements to end the loop.
        }

        Console.ReadLine();

        // Using a while loop for this block
        Console.WriteLine("Lets see if your guess can beat mine?\n" +
            "guess your number...");
        int guess = Convert.ToInt32(Console.ReadLine());

        while (guess < 20 )// using a while loop to get the user to guess a number. will only work if they guess under.
        {
            Console.WriteLine(guess + " Your guess was smaller then mine. lets add one to see how far you are?");
            guess++;
        }

        Console.ReadLine();

        Console.WriteLine("Now give me a number from: 1-10");
        int bigNum = Convert.ToInt32(Console.ReadLine());

        while ( bigNum <= 10)
        {
            Console.WriteLine("Your number is: " + bigNum + ".\n" +
                "Now lets keep adding to it.");
            bigNum++;
        }
        Console.ReadLine();

        // block for list 
        List<string> stringList = new List<string>() { "whale", "dog", "bird", "fridge", "water", "car"};// initializing a list with strings

        Console.WriteLine("Please give a word to search inside the list.");
        string giveWord = Console.ReadLine();// We take the input from the user
        bool words = false;// we use a boolean for the while loop

        do// we use a do to make sure the while loop goes through at least once if they guess the word correctly the first time
        {
            switch (giveWord)
            {
                case "whale":
                    Console.WriteLine("Your word was found: " + giveWord);
                    words = true;// after they get a correct guess we change the bool to true to get out of the while loop
                    break;
                case "dog":
                    Console.WriteLine("Your word was found: " + giveWord);
                    words = true;
                    break;
                case "bird":
                    Console.WriteLine("Your word was found: " + giveWord);
                    words = true;
                    break;
                case "fridge":
                    Console.WriteLine("Your word was found: " + giveWord);
                    words = true;
                    break;
                case "water":
                    Console.WriteLine("Your word was found: " + giveWord);
                    words = true;
                    break;
                case "car":
                    Console.WriteLine("Your word was found: " + giveWord);
                    words = true;
                    break;
                default:
                    Console.WriteLine("Your word was not found.\n" +
                        "Try another word.");
                    giveWord = Console.ReadLine();
                    break;

            }
        }
        while (!words);

        Console.ReadLine();
        // block for guessing with a list and iterating through it.
        List<string> colors = new List<string>() { "red", "orange", "yellow", "green", "blue", "indigo", "violet", "green" };
        Console.WriteLine("Please select a color of the rainbow to search our list.");
        string search = Console.ReadLine();
        bool matchExists = false;

        for (int i = 0; i < colors.Count; i++)// the for loop to get the index value of each item.
        {
            if ( colors[i] == search)// if the input is matched do this
            {
                matchExists = true;
                Console.WriteLine("the color is on index: " + i);
            }
        }
        if(matchExists == false)// if the input was unmatch then do this chunk
        {
            Console.WriteLine("sorry, The color you chose is not on the list.");
        }
        Console.ReadLine();

        // block for checking if an item on a list is dupkicate. 
        List<string> cities = new List<string>() { "Phoenix", "Tombstone", "Cuduhay", "London", "Phoenix" };// initializing a list with strings
        List<string> checkList = new List<string>();// Create a new list to put the unique items in there.

        foreach (string city in cities)// we use a foreach loop to iterate through the list items
        {
            if (checkList.Contains(city))// checks if the second list contains the item
            {
                Console.WriteLine(city + ": This has been on the list before");// if the item is not on the second list we then add it
                checkList.Add(city);
            }
            else// else we dont add to the list.
            {
                Console.WriteLine(city + ": This has not been on the list before");
            }
        }
        Console.ReadLine();
    }
}
