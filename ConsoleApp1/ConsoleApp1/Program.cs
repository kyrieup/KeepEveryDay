using System;
using System.Security.Cryptography;

namespace haftFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HaftFind(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
            
        }

        public static int HaftFind(int[] nums , int target) 
        {
            //找好区间
            int left = 0;
            int right = nums.Length;
            //左闭右开
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid;
                }
            }
            return -1;
        }
    }




}
