public static class Solution
{
    public static void Main()
    {
        Console.WriteLine(NumOfPairs( new string[] { "777", "7", "77", "77" }, "7777"));
        Console.ReadKey();
    }

    public static int NumOfPairs(string[] nums, string target)
    {
        short result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) { continue; }
                if (nums[i] + nums[j] == target) { ++result; }
            }
        }
        return result;
    }
}