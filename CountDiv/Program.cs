using System;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(6, 11, 2));
        }
    }

    class Solution
    {
        public int solution(int A, int B, int K)
        {
            int offsetForLeftRange = 0;

            if (A % K == 0)
            {
                ++offsetForLeftRange;
            }

            return B / K - A / K + offsetForLeftRange;
        }
    }
}
