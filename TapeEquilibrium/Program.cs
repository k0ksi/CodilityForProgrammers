using System;
using System.Linq;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Solution().solution(new int[] { 3, 1, 2, 4, 3 }));
            Console.WriteLine(new Solution().solution(new int[] { 0, 0, 20 }));
        }
    }

    class Solution
    {
        public int solution(int[] nums)
        {
            int minDiff = int.MaxValue;
            
            int sumOfAll = nums.Sum();

            int currentSum = nums[0];
            int rest = sumOfAll - currentSum;

            int currentDiff = Math.Abs(currentSum - rest);

            if(currentDiff < minDiff)
            {
                minDiff = currentDiff;
            }

            for (int i = 1; i < nums.Length - 1; i++)
            {
                int num = nums[i];

                currentSum += num;
                rest = sumOfAll - currentSum;
                currentDiff = Math.Abs(currentSum - rest);

                if (currentDiff < minDiff)
                {
                    minDiff = currentDiff;
                }
            }

            return minDiff;
        }
    }
}
