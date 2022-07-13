using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphism
{
    public abstract class Person
    {
        //set the properties of the class
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName(string firstName, string lastName)//class has two parameters for method
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);//write the full name to the console
        }
    }
}
