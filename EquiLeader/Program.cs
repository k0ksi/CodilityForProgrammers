using System;
using System.Collections.Generic;

namespace EquiLeader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 4, 3, 4, 4, 4, 2 }));
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

            for (int i = 0; i < n; i++)
            {
                if (A[i] == candidate)
                {
                    count++;
                }
            }

            if (count > n / 2)
            {
                leader = candidate;
            }

            int equileaderCounter = 0;
            int leadersCountSoFar = 0;

            for (int i = 0; i < n; i++)
            {
                int current = A[i];

                if(current == leader)
                {
                    leadersCountSoFar++;
                }

                if(leadersCountSoFar > (i + 1) / 2 && count - leadersCountSoFar > (n - i - 1) / 2)
                {
                    equileaderCounter++;
                }
            }

            return equileaderCounter;
        }
    }
}
