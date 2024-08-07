using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demomath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the number");
            int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num);
            if (num%2==0) {
                Console.WriteLine("Number is even");
            }
            else { Console.WriteLine("Number is odd"); }
            Console.ReadLine();
        }
        public void Main ()
        { Console.WriteLine("df");
        Console.ReadLine(); 
        }
    }
}
