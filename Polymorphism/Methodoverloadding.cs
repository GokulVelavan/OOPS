using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Methodoverloadding
    {
        public void add(int a,int b,int c)
        {
            Console.WriteLine("sum :{0}", a + b + c);
        }
        public void add(int a, int b)
        {
            Console.WriteLine("sum :{0}", a + b);
        }

        public void add(double a, double b)
        {
            Console.WriteLine("sum :{0}", a + b);
        }
    }
}
