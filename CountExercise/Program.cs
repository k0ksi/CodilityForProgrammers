using System;

namespace CountExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstantTime(5));
        }

        static int Slow(int n)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    result += 1;
                }
            }

            return result;
        }

        static int Fast(int n)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += (i + 1);
            }

            return result;
        }

        static int ConstantTime(int n)
        {
            int result = n * (n + 1) / 2;

            return result;
        }
    }
}
