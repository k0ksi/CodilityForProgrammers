using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { int.MinValue, int.MinValue, 2, 5, 1, 8, 20 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;

            int result = 0;

            Array.Sort(A);

            if(n < 3)
            {
                return result;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    int p = A[i - 2];
                    int q = A[i - 1];
                    int r = A[i];

                    long firstSum = (long)p + (long)q;
                    long secondSum = (long)q + (long)r;
                    long thirdSum = (long)r + (long)p;

                    if (firstSum > r && secondSum > p && thirdSum > q)
                    {
                        result = 1;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
