using System;
using System.Linq;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(529));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            var count = 0;

            var binary = Convert.ToString(n, 2);

            var results = binary
                .Trim('0')
                .Split('1')
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            foreach (var item in results)
            {
                if(item.Length > count)
                {
                    count = item.Length;
                }
            }

            return count;
        }
    }
}
