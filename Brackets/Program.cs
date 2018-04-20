using System;
using System.Collections.Generic;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 2, 1, 4, 0 };

            var array = new Solution().solution("({([)})]");
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(string s)
        {
            int result = 0;

            Dictionary<char, char> symbols = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            if (string.IsNullOrEmpty(s))
            {
                return 1;
            }

            Stack<char> stack = new Stack<char>();

            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                char symbol = s[i];

                switch (symbol)
                {
                    case '}':
                    case ']':
                    case ')':
                        if (stack.Count > 0)
                        {
                            if (symbols.ContainsKey(stack.Peek()) && symbol == symbols[stack.Peek()])
                            {
                                stack.Pop();
                                continue;
                            }
                        }
                        break;
                }

                stack.Push(symbol);
            }

            if (stack.Count == 0)
            {
                result = 1;
            }


            return result;
        }
    }
}
