using System;

namespace SortSq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temp = SortedSquaresSimple(new int[] { -4, -3, -1, 0, 4, 7 });
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }

        }
        public static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }
            Array.Sort(result);
            return result;
        }

        public static int[] SortedSquaresSimple(int[] nums) 
        {
            int[] result = new int[nums.Length];
            int start = 0;
            int end = nums.Length - 1;
            int num = 0;
            while (start <= end)
            {
                if (nums[start] * nums[start] > nums[end] * nums[end])
                {
                    result[result.Length - num - 1] = nums[start] * nums[start];
                    start++;
                }
                else
                {
                    result[result.Length - num - 1] = nums[end] * nums[end];
                    end--;
                }
                num++;
            }

            return result;

        }

    }
}
