using System;
using System.Collections.Generic;
using System.Linq;

namespace MinAvgTwoSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 4, 2, 2, 5, 1, 5, 8 }));
            Console.WriteLine(new Solution().solution(new int[] { 3,2,1, 1 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;

            if (n == 2)
            {
                return 0;
            }

            int firstNum = A[0];
            int secondNum = A[1];

            int minSliceTwo = firstNum + secondNum;
            int minTwoIndex = 0;

            int minSliceThree = int.MaxValue;
            int minThreeIndex = 0;
            
            for (int i = 2; i < n; i++)
            {
                int sliceTwo = A[i - 1] + A[i];
                if (sliceTwo < minSliceTwo)
                {
                    minSliceTwo = sliceTwo;
                    minTwoIndex = i - 1;
                }

                int sliceThree = sliceTwo + A[i - 2];
                if (sliceThree < minSliceThree)
                {
                    minSliceThree = sliceThree;
                    minThreeIndex = i - 2;
                }
            }

            int averageMinTwo = minSliceTwo * 3;
            int averageMinThree = minSliceThree * 2;

            if (averageMinTwo == averageMinThree)
            {
                return Math.Min(minTwoIndex, minThreeIndex);
            }
            else
            {
                return averageMinTwo < averageMinThree ? minTwoIndex : minThreeIndex;
            }
        }
    }
}
