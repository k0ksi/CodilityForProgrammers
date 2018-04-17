using System;
using System.Linq;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 4, 1, 3, 2 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int result = 1;

            int n = A.Length;

            long max = (long)A.Max() + 1;

            if (max > A.Length + 1)
            {
                return 0;
            }

            long[] count = new long[max];

            for (int i = 0; i < n; i++)
            {
                count[A[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] != 1)
                {
                    result = 0;
                    break;
                }
            }

            return result;
        }
    }
}
