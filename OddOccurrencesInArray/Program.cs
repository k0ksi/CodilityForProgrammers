using System;
using System.Collections.Generic;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (var item in A)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }

            foreach (var item in dictionary)
            {
                if(dictionary[item.Key] % 2 != 0)
                {
                    return item.Key;
                }
            }

            return 0;
        }
    }
}
