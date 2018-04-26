using System;

namespace MinPerimeterRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(1));
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            //int numFactors = 0;
            int result = int.MaxValue;

            for (int i = 1; i <= (double)Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    int perimeter = CalcPerimeter(i, N);
                    if(perimeter < result)
                    {
                        result = perimeter;
                    }
                    //if (i * i != N)
                    //{
                    //    numFactors = numFactors + 2;
                    //}
                    //else if (i * i == N)
                    //{
                    //    numFactors = numFactors + 1;
                    //}
                }
            }
            return result;
        }

        private int CalcPerimeter(int i, int N)
        {
            int sideA = i;
            int sideB = N / i;

            int perimeter = (sideA + sideB) * 2;

            return perimeter;
        }
    }
}
