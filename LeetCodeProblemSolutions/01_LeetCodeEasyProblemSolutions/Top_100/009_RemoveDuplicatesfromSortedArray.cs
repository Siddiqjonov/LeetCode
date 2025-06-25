namespace _01_LeetCodeEasyProblemSolutions.Top_100
{
    internal class _009_RemoveDuplicatesromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var distinctNums = nums.Distinct().ToArray();

            int k = 1;
            for (int i = 1; i < distinctNums.Length; i++)
            {
                nums[i] = distinctNums[i];
                k++;
            }

            return k;
        }
    }
}
