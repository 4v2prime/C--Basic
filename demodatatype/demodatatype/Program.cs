using System;

namespace demodatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            string lapyop = "Uses mi laptop";
            bool male = true;
            float cgpa = 8.10F;
            double something = 87.2351963;
            string name = "PrIme";
            Console.WriteLine("Age"+ "-" +age);
            Console.WriteLine("Is he male"+ "-"+ male);
            Console.WriteLine(lapyop);
            Console.WriteLine("Degree CGPA"+"-" +cgpa);
            Console.WriteLine("Something to show double"+"-"+ something);
            Console.WriteLine("Name"+"-"+name);


            Console.ReadKey();
        }
    }
}
