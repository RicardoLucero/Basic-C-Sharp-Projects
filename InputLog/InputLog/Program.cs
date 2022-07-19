using System;
using System.IO;

namespace InputLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a Number");//ask the user for input
            string number = Console.ReadLine();//place the input in a string variable
            using (StreamWriter file = new StreamWriter(@"C:\Users\ricar\OneDrive\Documents\Logs\Numlog.txt", true))// we use streamwriter to append to the file called file. 
                //the text file is called Numlog.txt. the true bool says to append to the file 
            {
                file.WriteLine(number);//using file.writeline to append to the filel what is in the parenthesis
            }
            Console.WriteLine(number);//write the number to the console to tell the user what they have inputed.
        }
    }
}
