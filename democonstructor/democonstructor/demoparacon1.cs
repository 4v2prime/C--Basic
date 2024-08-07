using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace democonstructor
{
    internal class demoparacon1
    {
        int password;
        int x;
        public demoparacon1(int password)
        {
           x = password;
        }
        public demoparacon1(demoparacon1 obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is " + x);
        }
        static void Main()
        {
            demoparacon1 cd1 = new demoparacon1(10);
            cd1 .Display();
            demoparacon1 cd2 = new demoparacon1(cd1);
            cd2.Display();
            demoparacon1 cd3 = new demoparacon1(cd1);
            cd3.Display();
            Console.ReadLine();
        }
    }
}
