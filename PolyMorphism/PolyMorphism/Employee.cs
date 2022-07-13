using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphism
{
    //the class is inheriting from the Person class
    //also inheriting from the Interface IQuittable
    public class Employee : Person, IQuittable
    {
        //override keyword used to add to the virtual method or just to use it.
        public override void SayName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
        //define the method in the implementation of the method
        public void Quit()
        {
            Console.WriteLine("I Quit!!!");
        }
    }
}
