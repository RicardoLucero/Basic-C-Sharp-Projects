using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new list of employees
            List<Employee> employeeList = new List<Employee>
            {
                //initializing the list with employees
                new Employee { ID=1, firstName="Joe", lastName = "Niel" },
                new Employee { ID=2, firstName= "Becky", lastName = "Smith" },
                new Employee { ID = 3, firstName = "Troy", lastName = "Johnson" },
                new Employee { ID = 4, firstName = "Jasmine", lastName = "Williams" },
                new Employee { ID = 5, firstName = " Tony", lastName = "Brown" },
                new Employee { ID = 6, firstName = "Nami", lastName = "Jones" },
                new Employee { ID = 7, firstName = "Joe", lastName = "Kelly" },
                new Employee { ID = 8, firstName = "Bryan", lastName = "Garcia" },
                new Employee { ID = 9, firstName = "Roger", lastName = "Miller" },
                new Employee { ID = 10, firstName = "Cruella", lastName = "Deville" }
            };
            //Create a second new list to add the employees to
            List<Employee> newList = new List<Employee>();
            //Create a foreach loop to iterate through the list of employees
            foreach (Employee employee in employeeList)
            {//if the employee first name is equal to Joe 
                if (employee.firstName == "Joe")
                {//add it to the new list
                    newList.Add(employee);
                }
            }//Create another foreach loop to list the employees in the new list
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName);
            }
            // now we create a new list to add the employees that have an ID greater than 5
            List<Employee> employeeID = employeeList.Where(x => x.ID > 5).ToList();
            //Once again we use a foreach loop to list the names of the employees that have an id > 5
            foreach (Employee employee in employeeID)
            {
                Console.WriteLine(employee.firstName);
            }
        }
    }
}
