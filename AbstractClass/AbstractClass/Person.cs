using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Person// create an abstract class with the abstract keyword
    {
        //set the properties of the class
        public string firstName { get; set; }
        public string lastName { get; set; }

        //create a virtual method to make the inheriting class use the method
        public virtual void SayName(string firstName, string lastName)//class has two parameters for method
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);//write the full name to the console
        }
    }
}
