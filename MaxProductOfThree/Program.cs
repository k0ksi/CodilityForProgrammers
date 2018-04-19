using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { -5, 5, -5, 4 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;

            Array.Sort(A);

            int max = int.MinValue;

            for (int i = 2; i < n; i++)
            {
                int p = A[i - 2];
                int q = A[i - 1];
                int r = A[i];

                int multiplicationResult = p * q * r;

                if (multiplicationResult > max)
                {
                    max = multiplicationResult;
                }
            }

            int firstTwoAndLast = A[0] * A[1] * A[n - 1];

            if(firstTwoAndLast > max)
            {
                max = firstTwoAndLast;
            }

            return max;
        }
    }
}
