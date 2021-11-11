using System;
namespace SolutionTest
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int sum = 0;
            int[] output = new int[nums.Length];


            for (int i = 0; i <= nums.Length; i++)
            {
                if (sum < target)
                {
                    sum = sum + nums[i];
                    output[i] = nums[i].GetHashCode();
                }
                // else if  (sum == target)
                // {
                //     break;
                // }
                else
                {
                    break;
                    // sum = sum - nums[i];
                }
            }

            return output;
        }
    }
}