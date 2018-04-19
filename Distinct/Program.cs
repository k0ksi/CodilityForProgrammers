using System;
using System.Linq;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 2,1,1,2,3,1 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;

            Array.Sort(A);

            //int result = 1;

            //if(n == 0)
            //{
            //    return 0;
            //}



            return A.Distinct().Count();
        }
    }
}
