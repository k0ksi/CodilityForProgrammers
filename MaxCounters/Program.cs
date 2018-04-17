using System;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", new Solution().solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 })));
        }
    }

    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int[] counter = new int[N];
            int max = -1;
            int currentMin = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 1 && A[i] <= N)
                {
                    if (counter[A[i] - 1] < currentMin)
                        counter[A[i] - 1] = currentMin;

                    counter[A[i] - 1] = counter[A[i] - 1] + 1;

                    if(counter[A[i] - 1] > max)
                    {
                        max = counter[A[i] - 1];
                    }
                }
                else if(A[i] == N + 1)
                {
                    currentMin = max;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if(counter[i] < currentMin)
                {
                    counter[i] = currentMin;
                }
            }

            return counter;
        }
    }
}
