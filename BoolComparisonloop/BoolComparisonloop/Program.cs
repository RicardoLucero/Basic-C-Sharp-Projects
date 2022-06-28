using System;

namespace BoolComparisonloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s play paper, rock, scissors!\n" +
                "choose either rock, paper, or scissors.");
            string winner = Console.ReadLine();// Create a variable to compare to our winning variable
            bool win = winner == "rock";// Create a boolean variable to sun our loop and check whether or not to keep looping

            do// The do loop makes sure the loop gets done at least once. It's in case the user
                //guesses the correct variable the first time. If they did the loop would not run and we would not 
                //get the operation that we wanted.
            {
                switch (winner)// Switch causes a branching to start with the variable we created earlier it will check for the 
                    //response from the user to give a case response.
                {
                    case "paper":// The first case is the first branch that the user will run into.
                        Console.WriteLine("You played Paper and I chose Scissors, You Lose!");
                        Console.WriteLine("Try again?");
                        winner = Console.ReadLine();// We need to reset the variable before the end of the branch so when 
                        //we run the loop it gives a new case response.
                        break;// Ends this branch and lets the program know. With the while loop it will know to start the loop now.
                    case "scissors":
                        Console.WriteLine("You played Scissors and I chose Rock, You Lose!");
                        Console.WriteLine("Try again?");
                        winner = Console.ReadLine();
                        break;
                    case "rock":// This is our correct variable response
                        Console.WriteLine("You played Rock and I chose Scissors, You Win!!!");
                        win = true;// The boolean variable is set to true so that the loop will end when we reach the end of the branch.
                        break;
                    default:// The defualt is a case for anything we didn't specify.
                        // The default will make sure the user only gives us one of the responses we want.
                        Console.WriteLine("You did not choose any of the options.");
                        Console.WriteLine("Please, Try again?");
                        winner = Console.ReadLine();
                        break;
                }
            }

            while (!win);// This is the while loop we state that while the boolean variable 'win' equals false then do the loop.

            Console.ReadLine();
        }
    }
}
