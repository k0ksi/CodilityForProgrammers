using System;
using System.Linq;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 1,2,3 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int max = A.Max();

            if(max <= 0)
            {
                return 1;
            }

            if(max == 1)
            {
                return 2;
            }

            bool[] occurs = new bool[max + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] > 0)
                {
                    occurs[A[i]] = true;
                }
            }
            
            for (int i = 1; i < occurs.Length; i++)
            {
                if(occurs[i] == false)
                {
                    return i;
                }
            }
            
            return max + 1;
        }
    }
}
