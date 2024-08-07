using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace demoCollection1
{
    internal class stack1
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            //st.Pop();
            foreach(Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();Console.WriteLine();
            Console.WriteLine("The number of element in the stck "+st.Count);
            Console.WriteLine("Does the stack contain the element 3 "+st.Contains(3));
            Console.ReadKey();
        }
    }
}
