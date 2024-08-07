using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        for (int i=1; i<=3;i++)
        {
            for(int j = 1; j <= i; j++) { 
            
                Console.WriteLine(i + " " + j);
                
            }
        } Console.ReadKey();
    }
}