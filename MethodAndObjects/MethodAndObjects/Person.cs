using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }//set the properties as string type
        public string LastName { get; set; }

        public void SayName()// create a method to write the full name of the Person
        {
            string fullName = FirstName + " " + LastName;// concatanate the properties to make the full name
            Console.WriteLine("Name: " + fullName);// write to the console the full name
        }
    }
}
