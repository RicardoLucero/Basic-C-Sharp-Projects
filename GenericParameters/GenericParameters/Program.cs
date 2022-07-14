using System;
using System.Collections.Generic;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the list with the data type parameter
            Employee<string> items = new Employee<string>();
            //create an object of the List
            items.things = new List<string>();
            //add the items to the List
            items.things.Add("keys");
            items.things.Add("phone");
            items.things.Add("wallet");
            items.things.Add("lunchbag");
            items.things.Add("badge");
            //instantiate the list with the data type parameter
            Employee<int> numbers = new Employee<int>();
            //create an object of the list
            numbers.things = new List<int>();
            //add the numbers to the list
            numbers.things.Add(47);
            numbers.things.Add(99);
            numbers.things.Add(666);
            numbers.things.Add(777);
            numbers.things.Add(69);
            // create a foreach loop to iterate through the list
            foreach (string item in items.things)
            {//write each item to the console as you iterate through the list
                Console.WriteLine("You have a " + item);
            }
            // create another foreach loop for the second list
            foreach (int number in numbers.things)
            {
                Console.WriteLine("You're number is " + number);
            }
        }
    }
}
