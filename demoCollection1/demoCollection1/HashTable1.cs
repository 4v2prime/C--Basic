using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace demoCollection1
{
    internal class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");
            ICollection keys = ht.Keys;
            foreach (string k in keys) { Console.WriteLine(ht[k]); }
            Console.ReadLine();
        }
    }
}
