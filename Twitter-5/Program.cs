using System;
using System.Collections.Generic;

namespace Twitter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long p = Convert.ToInt64(Console.ReadLine().Trim());

            long result = pthFactor(n, p);

            Console.WriteLine(result);
        }

        public static long pthFactor(long n, long p)
        {

            List<long> factors = new List<long>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                }

                factors.Sort();
            }

            foreach (var num in factors)
            {
                if (p > factors.Count)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }

            //if (p > factors.Count)
            //{
            //    return 0;
            //}
            //else
            //{
            //    var convert = factors.;
            //    return convert;
            //}
        }
    }
}
