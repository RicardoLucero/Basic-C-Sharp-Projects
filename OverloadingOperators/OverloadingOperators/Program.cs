using System;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the first object of Employee
            Employee personOne = new Employee() { ID = 001, FirstName = "Josh", LastName = "Myers" };//intialize the first object

            //Instantiate the second object of Employee
            Employee personTwo = new Employee() { ID = 002, FirstName = "Bryan", LastName = "Cranston" };//initialize the second object

            //we use the overloaded operators to check if the employees are the same
            if (personOne.ID == personTwo.ID)
                Console.WriteLine("This is the same employee");
            if (personOne.ID != personTwo.ID)
                Console.WriteLine("This is not the same employee");
        }
    }
}
