using System;

namespace PolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //we instantiate the class as a new object named person
            Employee person = new Employee();
            //using polymorphism to create an object of an interface
            IQuittable quiter = new Employee();
            //intializing the object with the properties
            person.firstName = "Sample";
            person.lastName = "Student";
            //calling the method and passing the arguments
            person.SayName(person.firstName, person.lastName);
            //calling the Quit meethod
            quiter.Quit();
        }
    }
}
