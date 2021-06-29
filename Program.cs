using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {                
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    continue;
                }            
                if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    continue;
                }
                System.Console.WriteLine(i);
            }
        }
    }
}
