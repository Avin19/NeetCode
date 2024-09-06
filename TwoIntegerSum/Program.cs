// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] nums = { 4, 5, 6 };
int target = 10;

Solution solution = new Solution();
int[] output = solution.TwoSum(nums, target);
foreach (int i in output)
{
    Console.WriteLine(i);
}

