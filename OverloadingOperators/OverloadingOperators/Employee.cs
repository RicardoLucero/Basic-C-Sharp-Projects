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
        public static bool operator == (Employee person, Employee ID)
        {           
            return person.Equals(ID);//we return true if the ID is found
        }
        //overload the != operator
        public static bool operator != (Employee person, Employee ID)
        {
            return ! person.Equals(ID);//we return false if the ID is not found
        }
    }
}
