using System;

namespace PrefixSumsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrefixSums(new int[] { 1, 2, 3 }));
            Console.WriteLine(TotalOfOneSliceCount(new int[] {1,2,3,4,5}, 1, 3));
        }

        static int[] PrefixSums(int[] A)
        {
            int n = A.Length;
            int[] P = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                P[i] = P[i - 1] + A[i - 1];
            }

            return P;
        }

        static int[] SuffixSums(int[] A)
        {
            int n = A.Length;
            int[] P = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                P[i] = P[i - 1] + A[A.Length - i];
            }

            return P;
        }

        static int TotalOfOneSliceCount(int[] P, int x, int y)
        {
            return P[y + 1] - P[x];
        }
    }
}
