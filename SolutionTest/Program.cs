using System;
namespace SolutionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Console.WriteLine(Solution.TwoSum(nums,target));
        }
    }
}
