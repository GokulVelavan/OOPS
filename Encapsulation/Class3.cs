using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Class3:Class2
    {
        public void Display3()
        {
            Console.WriteLine("I am a public method");

        }
        public string password//getter and setter method
        {
            set;
            get;

        }
    }
   
}
