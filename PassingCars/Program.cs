using System;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 0, 1, 0, 1, 1 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int count = 0;

            // TODO
            int zeroesFound = 0;
            int firstZeroIndex = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int num = A[i];

                if(num == 0)
                {
                    zeroesFound = 1;
                    firstZeroIndex = i;

                    break;
                }
            }

            if(firstZeroIndex < A.Length)
            {
                for (int i = firstZeroIndex + 1; i < A.Length; i++)
                {
                    int num = A[i];

                    if (num == 0)
                    {
                        zeroesFound++;
                    }
                    else
                    {
                        count += zeroesFound;
                        if (count > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }

            return count;
        }
    }
}
