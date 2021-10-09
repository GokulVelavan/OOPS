using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Methodoverloadding obj = new Methodoverloadding(); 
            obj.add(5, 5,5);
            obj.add(5, 5);
            obj.add(4.5, 4.5);

            //MethodOverriding
            Methodoverridding obj2 = new Methodoverridding();
            Methodoverridding obj3 = new Birds();
            obj2.Animal();
            obj3.Animal();
            Console.ReadLine();

        }
    }
}
