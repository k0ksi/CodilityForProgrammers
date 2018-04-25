using System;
using System.Collections.Generic;

namespace Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 2, 1, 5 };
            int[] arr2 = new int[] { 0, 1, 0, 0, 0 };

            var array = new Solution().solution(arr, arr2);
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(int[] A, int[] B)
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int size = A[i];
                int dir = B[i];

                if (s.Count == 0)
                {
                    s.Push(i);
                }
                else
                {
                    while (s.Count > 0 && dir - B[s.Peek()] == -1 && A[s.Peek()] < size)
                    {
                        s.Pop();
                    }

                    if (s.Count > 0)
                    {
                        if (dir - B[s.Peek()] != -1)
                        {
                            s.Push(i);
                        }
                    }
                    else
                    {
                        s.Push(i);
                    }
                }
            }

            return s.Count;
        }
    }
}
