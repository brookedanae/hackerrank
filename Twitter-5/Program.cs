using System;
using System.Collections.Generic;

namespace Twitter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            Console.WriteLine("Enter a power: ");
            long p = Convert.ToInt64(Console.ReadLine().Trim());

            long result = pthFactor(n, p);

            Console.WriteLine(result);
        }

        public static long pthFactor(long n, long p)
        {
            long maxLimit = n;

            List<long> firstHalfFactors = new List<long>();
            firstHalfFactors.Add(1);

            for (int i = 2; i < maxLimit; i++)
            {
                if (n % i == 0)
                {
                    maxLimit = n / i;
                    firstHalfFactors.Add(i);
                }
            }

            long size = firstHalfFactors.Count;

            if (p <= size)
            {
                return firstHalfFactors[(int)p - 1];
            }
            if (p <= 2 * size)
            {
                var inverse = firstHalfFactors[(int)(2 * size - p)];
                if (Math.Pow(firstHalfFactors[(int)size - 1], 2) == n)
                {
                    var index = (int)(2 * size - p) - 1;
                    if (index < 0)
                    {
                        return 0;
                    }
                    inverse = firstHalfFactors[index];
                }
                return n / inverse;
            }
            return 0;
        }
    }
}
