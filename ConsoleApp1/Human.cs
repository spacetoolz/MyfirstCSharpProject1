using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human


    {
        public Human() { }

        public Human (string FName, string LName)
        {
            FirstName = FName;
            LastName = LName;
        }


        public string FirstName { get; set; } // This is a getter and setter for the first name in C#
        // Unlike in C++ where you had to use a function, you just type the statement like this in C#
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string HairColour { get; set; }
        public double Weight { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        } 
    }
    
}
