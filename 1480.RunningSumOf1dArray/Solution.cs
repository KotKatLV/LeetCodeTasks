public static class Solution
{
    public static void Main()
    {
        Console.WriteLine(RunningSum(new int[] { 1, 2, 3, 4 }));
        Console.ReadKey();
    }

    public static int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; ++i)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}