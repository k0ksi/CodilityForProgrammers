using System;

namespace MaxSliceProblemDemoExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LinearSolution(new int[] {5,-7,3,5-2,4,-1}));
        }

        // O(n3)
        static int Quadradic(int[] A)
        {
            int n = A.Length;
            int result = 0;

            for (int p = 0; p < n; p++)
            {
                for (int q = p; q < n; q++)
                {
                    int sum = 0;

                    for (int i = p; i < q + 1; i++)
                    {
                        sum += A[i];
                    }

                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        // O(n2)
        static int FasterQuadraticPrefixSums(int[] A)
        {
            int[] pref = PrefixSums(A);
            int n = A.Length;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int sum = pref[j + 1] - pref[i];
                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        // O(n2)
        static int FasterQuadratic(int[] A)
        {
            int n = A.Length;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += A[j];
                    result = Math.Max(result, sum);
                }
            }

            return result;
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

        static int LinearSolution(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = 0;
            foreach (var a in A)
            {
                maxEnding = Math.Max(0, maxEnding + a);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}
