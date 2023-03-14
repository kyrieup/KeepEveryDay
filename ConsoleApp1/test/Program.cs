using System;

namespace RemoveTargetNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int slowIndex = 0;
            for (int fastIndex = 0; fastIndex < nums.Length; fastIndex++)
            {
                if (nums[fastIndex] != val)
                {
                    nums[slowIndex++] = nums[fastIndex];
                }
            }
            return slowIndex;
        }

        public static int RemoveElementCommon(int[] nums, int val)
        { 
            int size = nums.Length;
            for (int i = 0; i < size; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    i--;
                    size--;
                }
            }
            return size;
        
        }

    }
}
