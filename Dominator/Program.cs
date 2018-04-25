using System;
using System.Collections.Generic;

namespace Dominator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var number = A[i];

                if (stack.Count == 0)
                {
                    stack.Push(A[i]);
                }
                else
                {
                    if (stack.Peek() != A[i])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(A[i]);
                    }
                }
            }

            int candidate = -1;

            if (stack.Count > 0)
            {
                candidate = stack.Peek();
            }

            int leader = -1;
            int count = 0;
            int index = -1;

            for (int i = 0; i < n; i++)
            {
                if (A[i] == candidate)
                {
                    index = i;
                    count++;
                }
            }

            if (count > n / 2)
            {
                leader = candidate;
                return index;
            }

            return leader;
        }
    }
}
