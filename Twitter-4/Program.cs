using System;
using System.Collections.Generic;

namespace Twitter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new List<string> { "code", "doce", "ecod", "framer", "frame" };

            foreach (var item in text)
            {
                if (item[0] != item[1])
                {
                    text.RemoveAt(1);
                }
                Console.WriteLine(item);
            }
        }

        public static void removeWord(List<string> removed, int N)
        {
            List<string> result = new List<string>();

            HashSet<string> found = new HashSet<string>();

            for (int i = 0; i < N; i++)
            {
                string word = removed[i];

                if (!found.Contains(word))
                {
                    result.Add(removed[i]);
                    found.Add(word);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i] + " ");
            }
    }
    }
}
