using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Methodoverridding
    {
        public void Animal()
        {
            Console.WriteLine("Animal Kingdom");
        }
    }

    public class Birds : Methodoverridding
    {
        public void Animal()
        {
            Console.WriteLine("Bird Kingdom");

        }
    }
}
