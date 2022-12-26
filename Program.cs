using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, Last, d = 0;

            Console.WriteLine("Start Number:-");
            
            start = int.Parse(Console.ReadLine());
            
            Console.WriteLine("End Number:-");
            
            Last = int.Parse(Console.ReadLine());

            for (int E = start; E < Last; E++)
            {
                for (int y = 1; y < Last; y++)
                {
                    if (E % y == 0)
                    {
                        d++;
                    }
                }

                if (d == 2)
                {
                    Console.WriteLine(E + " is a Prime Number");
                }
                d = 0;
            }
        }
    }
}