using System;

namespace CountFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(24));
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            int numFactors = 0;
            for (int i = 1; i <= (double)Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i * i != N)
                    {
                        numFactors = numFactors + 2;
                    }
                    else if (i * i == N)
                    {
                        numFactors = numFactors + 1;
                    }
                }
            }
            return numFactors;
        }
    }
}
