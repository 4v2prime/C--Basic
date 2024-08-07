using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoPolyOverloading
{
   class Number
    {
        public int value(int a, int b)
        {
            return a + b;
        }
    }
    class ChildNumber:Number
    {
        public int value(int a, int b)
        { return a - b; }
        static void Main()
        {
            ChildNumber cd1 = new ChildNumber();
            Console.WriteLine(cd1.value(10,4));
            Console.ReadLine();
        }
    }
}
