using System;

namespace IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Given an integer, perform the following conditional actions:

            // If is odd, print Weird
            // If is even and in the inclusive range of 2 to 5, print Not Weird
            // If is even and in the inclusive range of 6 to 20, print Weird
            // If is even and greater than 20, print Not Weird

            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 2 && N < 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && N > 6 && N < 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }

        }
    }
}
