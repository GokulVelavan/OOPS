using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1(); //creating object for child class

              obj.Display();         //calling child class methods by the object

              Console.ReadLine();
        }
    }
}
