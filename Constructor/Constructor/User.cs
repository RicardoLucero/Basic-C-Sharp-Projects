using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class User
    {
        //create a class of user to chain constructors
        public string userName;
        public string city;

        public User (string userName) : this(userName, "Los Angeles")// this method takes only one construct and the second one is a default value
        {
            //it does not need anyting in the curly braces as it chains off the other constructors 
        }

        public User (string userName, string city)//this takes two constructors
        {
            this.userName = userName;
            this.city = city;
        } 
    }
}
