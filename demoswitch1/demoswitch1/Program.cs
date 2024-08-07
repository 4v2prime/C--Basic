using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoswitch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 1;
            switch (value)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                default:
                    Console.WriteLine("Value is Different");
                    break ;
            }
            Console.ReadKey();
        }
    }
}
