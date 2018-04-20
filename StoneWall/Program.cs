using System;
using System.Collections;
using System.Collections.Generic;

namespace StoneWall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 };

            var array = new Solution().solution(arr);
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(int[] H)
        {
            Stack<int> stack = new Stack<int>();
            int blockCount = 0;
            for (int i = 0; i < H.Length; i++)
            {
                var elem = H[i];

                while(stack.Count != 0 && elem < stack.Peek())
                {
                    stack.Pop();
                    blockCount++;
                }

                if(stack.Count == 0 || elem > stack.Peek())
                {
                    stack.Push(elem);
                }
            }

            blockCount += stack.Count;

            return blockCount;
        }
    }
}
