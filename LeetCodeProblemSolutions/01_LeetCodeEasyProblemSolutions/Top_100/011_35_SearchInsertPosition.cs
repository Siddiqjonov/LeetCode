namespace _01_LeetCodeEasyProblemSolutions.Top_100;

internal class _011_35_SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        var small = nums.Where(x => x < target).DefaultIfEmpty().Max();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }

            if (nums[i] == small && small != 0)
            {
                return i + 1;
            }
        }
        return 0;
    }
}
