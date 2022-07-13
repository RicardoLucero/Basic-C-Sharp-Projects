using System;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the first object of Employee
            Employee employee1 = new Employee() { ID = 1, FirstName = "Josh", LastName = "Myers" };//intialize the first object

            //Instantiate the second object of Employee
            Employee employee2 = new Employee() { ID = 2, FirstName = "Bryan", LastName = "Cranston" };//initialize the second object

            //we use the overloaded operators to check if the employees are the same
            if (employee1 != employee2)
            {
                Console.WriteLine(employee1 != employee2);
            }
            else
            {
                Console.WriteLine(employee1 == employee2);
            }
        }
    }
}
