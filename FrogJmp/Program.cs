using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(10, 85, 30));
        }
    }

    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            //int start = X;
            //bool reached = false;
            //int counter = 0;
            //while(true)
            //{
            //    if(reached)
            //    {
            //        break;
            //    }


            //}

            decimal preciseResult = (decimal)(Y - X) / (decimal)D;

            return (int)Math.Ceiling(preciseResult);
        }
    }
}
