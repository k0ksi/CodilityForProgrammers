using System;

namespace ReverseArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(" ", Reverse(array)));
        }

        static int[] Reverse(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = array[i];
                int k = n - i - 1;
                array[i] = array[k];
                array[k] = temp;
            }

            return array;
        }
    }
}
