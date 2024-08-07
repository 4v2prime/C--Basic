using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 10 , val2 = 20 ;
            bool status = true;
            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!(status));
            Console.ReadKey();
        }
    }
}
