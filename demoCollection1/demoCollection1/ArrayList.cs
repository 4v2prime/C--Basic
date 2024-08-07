using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCollection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList(); 
            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);
            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Contains(2));
            a1.RemoveAt(1);
            Console.WriteLine(a1[1]);
            Console.ReadLine();

        }
    }
}
