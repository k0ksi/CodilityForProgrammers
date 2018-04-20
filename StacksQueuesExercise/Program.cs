using System;
using System.Collections.Generic;

namespace StacksQueuesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 0, 1, 1, 1, 0, 1 };

            Queue<int> queue = new Queue<int>();

            var res = 0;

            foreach (var item in A)
            {
                if(item == 0)
                {
                    queue.Enqueue(item);
                }
                else
                {
                    if(queue.Count > 0)
                    {
                        queue.Dequeue();
                    }
                    else
                    {
                        res++;
                    }
                }
            }

            Console.WriteLine(res);
            Console.WriteLine(GroceryStore(A));
        }

        static int GroceryStore(int[] A)
        {
            int n = A.Length;
            int size = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int operation = A[i];
                if(operation == 0)
                {
                    size++;
                }
                else
                {
                    size--;
                    result = Math.Max(result, -size);
                }
            }

            return result;
        }
    }
}
