using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperators
{
    public class Employee
    {
        //set the properties of the class
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //overload the == operator
        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
                Console.WriteLine("This is the same employee.");
            return true;//we return true if the ID is found
        }
        //overload the != operator
        public static bool operator != (Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
                Console.WriteLine("This is not the same employee.");
            return false;//we return false if the ID is not found
        }
    }
}
