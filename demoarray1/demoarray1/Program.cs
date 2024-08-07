using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoarray1
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int[] value;
            value=new int[5];
            value[0] = 1;
            value[1] = 2;
            value[2] = 3;
            value[3] = 4;
            value[4] = 5;
            Console.WriteLine(value);
           // Console.WriteLine(value[1]);
            //Console.WriteLine(value[2]);
            //Console.WriteLine(value[3]);
            //Console.WriteLine(value[4]);
            Console.ReadKey();
        }
       
    }
}
