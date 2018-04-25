using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().nsolution(new int[] { 6, 8, 4, 6, 8, 6, 6 }));
        }
    }

    class Solution
    {
        // O(n2)
        public int solution(int[] A)
        {
            int n = A.Length;
            int leader = -1;

            for (int i = 0; i < n; i++)
            {
                var candidate = A[i];
                var count = 0;
                for (int j= 0; j < n; j++)
                {
                    if(A[j] == candidate)
                    {
                        count++;
                    }
                }

                if(count > n / 2)
                {
                    leader = candidate;
                }
            }

            return leader;
        }

        // O(nlogn)
        public int logSolution(int[] A)
        {
            int n = A.Length;
            int leader = -1;
            Array.Sort(A);
            int candidate = A[n / 2];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if(A[i] == candidate)
                {
                    count++;
                }
            }

            if(count > n / 2)
            {
                leader = candidate;
            }

            return leader;
        }

        // O(n)
        public int nsolution(int[] A)
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
                    if(stack.Peek() != A[i])
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

            if(stack.Count > 0)
            {
                candidate = stack.Peek();
            }

            int leader = -1;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if(A[i] == candidate)
                {
                    count++;
                }
            }

            if(count > n / 2)
            {
                leader = candidate;
            }

            return leader;
        }
    }
}
