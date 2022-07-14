using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the struct Number
            Number number;

            //assigning a value to the number struct
            number.Amount = 47595;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
