// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            int diff = target - nums[i];
            foreach (int j in nums)
            {
                if (diff == j)
                {
                    return [i, j];
                }
            }

        }
        return null;
    }
}