using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Adiction";
            int x = 2;
            int y = 12;
            int sub = x - y;
            Console.WriteLine(str +" "+ x);
            Console.WriteLine(x + " " + y);
            Console.WriteLine("x+y" + " " + x + y);
            Console.WriteLine("x-y" + " " + sub);
            Console.WriteLine("Multipkication" + " " + x * y);
            Console.WriteLine("Division" + " " + y / x);
            Console.WriteLine("Remainder" + " " + y % x);
            Console.ReadLine();

        }



    }
}
