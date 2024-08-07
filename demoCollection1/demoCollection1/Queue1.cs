using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace demoCollection1
{
    internal class Queue1
    {
        static void Main(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);
            //qt.Dequeue();
            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();Console.WriteLine();
            Console.WriteLine("The number of elements in the Queue "+qt.Count);
            Console.WriteLine("Does the Queue Contain "+qt.Contains(3));
            Console.ReadLine();
        }
    }
}
