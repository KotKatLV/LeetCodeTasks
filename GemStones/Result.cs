class Result
{
    /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */
    public static int gemstones(List<string> arr)
    {
        // Slow solution
        //int result = 0;
        //string shortestString = arr.FirstOrDefault(x => x.Length == arr.Min(s => s.Length));
        //for (int i = 0; i < shortestString.Length; i++)
        //{
        //    if (arr.All(s => s.Contains(shortestString[i])))
        //    {
        //        result++;
        //    }
        //}

        // Fast solution
        int result = 0;
        int[] counters = new int[26];

        for (int i = 0; i < arr.Count; i++)
        {
            foreach (var c in arr[i])
            {
                int ind = c - 'a';
                if (counters[ind] == i)
                {
                    counters[ind]++;
                }
            }
        }

        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] == arr.Count)
            {
                result++;
            }
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> arr = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string arrItem = Console.ReadLine();
            arr.Add(arrItem);
        }

        int result = Result.gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}