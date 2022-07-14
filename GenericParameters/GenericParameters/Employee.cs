using System;
using System.Collections.Generic;
using System.Text;

namespace GenericParameters
{
    //create a generic class
    public class Employee<T>//The T is the generic keyword to let the list take a generic data type
    {
        //the data type is generic to allow the class that calls upon it to define the type
        public List<T> things { get; set; }
    }
}
