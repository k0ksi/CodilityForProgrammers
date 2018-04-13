using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(string.Join(",", new Solution().solution(new int[] { }, 3)));
        }
    }

    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            LinkedList<int> nums = new LinkedList<int>(A);

            if(nums.Count > 0)
            {
                for (int i = 0; i < K; i++)
                {
                    LinkedListNode<int> last = nums.Last;

                    nums.RemoveLast();
                    nums.AddFirst(last);
                }
            }

            return nums.ToArray();
        }
    }
}
