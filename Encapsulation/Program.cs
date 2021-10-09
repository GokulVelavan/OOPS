using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Class3 obj = new Class3();
            obj.Display3();

            obj.password = "Password";//calling getter and setter methods
            Console.WriteLine(obj.password);

            Console.ReadLine();
            

        }
    }
}
