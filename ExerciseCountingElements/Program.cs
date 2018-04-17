using System;
using System.Linq;

namespace ExerciseCountingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", QuadraticSwap(new int[] { 0, 0, 2, 4, 4, 5}, new int[] { 0, 0, 2, 4, 4, 0 }, 5)));
        }

        // O(n + m)
        static int[] LinearCount(int[] nums, int m)
        {
            int n = nums.Length;
            int[] count = new int[m + 1];
            for (int i = 0; i < n; i++)
            {
                count[nums[i]] += 1;
            }

            return count;
        }

        // Swap the Elements
        static bool QuadraticSwap(int[] firstArr, int[] secondArr, int m)
        {
            int n = firstArr.Length;
            int sumA = firstArr.Sum();
            int sumB = secondArr.Sum();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int change = secondArr[j] - firstArr[i];
                    sumA += change;
                    sumB -= change;

                    if(sumA == sumB)
                    {
                        return true;
                    }

                    sumA -= change;
                    sumB += change;
                }
            }

            return false;
        }

        // Swap the Elements
        // not sure if working correctly
        static bool LinearSwap(int[] firstArr, int[] secondArr, int m)
        {
            int n = firstArr.Length;
            int sumA = firstArr.Sum();
            int sumB = secondArr.Sum();
            int diff = sumB - sumA;

            if(diff % 2 == 1)
            {
                return false;
            }

            diff /= 2;
            int[] count = CountElements(firstArr, m);
            for (int i = 0; i < n; i++)
            {
                if(0 <= secondArr[i] - diff && secondArr[i] - diff <= m && count[secondArr[i] - diff] > 0)
                {
                    return true;
                }
            }

            return false;
        }

        static int[] CountElements(int[] X, int max)
        {
            int[] p = new int[max + 1];
            Array.Fill(p, 0);
            for (int i = 0; i < X.Length; i++)
            {
                p[X[i]]++;
            }

            return p;
        }
    }
}
