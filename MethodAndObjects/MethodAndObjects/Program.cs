using System;

namespace MethodAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();//Instantiate  the class
            person.FirstName = "Sample";//initializing the  object
            person.LastName = "Student";
            person.ID = 007;
            person.SayName();//calling the supermethod to write to console
            Console.ReadLine();
        }
    }
}
