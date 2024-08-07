using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demowhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 3, i = 0;
            while (i < value)
            {
                Console.WriteLine(i);
                i = i+1 ;
            }
            Console.ReadKey();
        }
    }
}
