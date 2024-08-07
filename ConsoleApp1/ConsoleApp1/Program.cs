using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
       static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 2, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum=0;
            Console.Write("The given Array is:");
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i]+",");
                sum = sum+ i;

            }
            Console.WriteLine();
            Console.WriteLine("Total Sum of the array :"+sum);
            Console.ReadLine();
        }



    }
}
