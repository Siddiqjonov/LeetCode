using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LeetCodeEasyProblemSolutions.Top_100
{
    internal class _010_RemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var numswithoutval = nums.Where(n => n != val).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < numswithoutval.Length)
                {
                    nums[i] = numswithoutval[i];
                }
                else
                {
                    nums[i] = 0;
                }
            }
            return numswithoutval.Length;
        }
    }
}
