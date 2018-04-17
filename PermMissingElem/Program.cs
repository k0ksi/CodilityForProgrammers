using System;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 2, 3, 1, 5 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            bool[] found = new bool[A.Length + 2];

            for (int i = 0; i < A.Length; i++)
            {
                found[A[i]] = true;
            }

            int result = 0;

            for (int i = 1; i < found.Length; i++)
            {
                if(found[i] == false)
                {
                    result = i;
                    break;
                }
            }

            return 1;
        }
    }
}
