using System;
using System.Collections.Generic;

namespace Twitter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string> { "code", "doce", "ecod", "framer", "frame" };

            int N = 5;

            removeWord(text, N);
        }

        public static void removeWord(List<string> removed, int N)
        {
            List<string> result = new List<string>();

            HashSet<string> found = new HashSet<string>();

            for (int i = 0; i < N; i++)
            {
                string word = removed[i];

                word = Sort(word);

                if (!found.Contains(word))
                {
                    result.Add(removed[i]);
                    found.Add(word);
                }
            }

            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i] + " ");
            }
        }

        public static string Sort(string input)
        {
            char[] newArray = input.ToCharArray();

            Array.Sort(newArray);

            return string.Join("", newArray);
        }
    }
}
