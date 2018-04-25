using System;
using System.Linq;

namespace MaxSliceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 3, 2, -6, 4, 0 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = 0;

            foreach (var a in A)
            {
                maxEnding = Math.Max(0, maxEnding + a);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            if(maxSlice == 0)
            {
                return A.Max();
            }

            return maxSlice;
        }
    }
}
