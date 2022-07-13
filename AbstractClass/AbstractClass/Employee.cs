using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person//the class is inheriting from the Person class
    {
        //override keyword used to add to the virtual method or just to use it.
        public override void SayName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
