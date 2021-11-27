using System.Text.RegularExpressions;

class Result
{
    public static int camelcase(string s)
    {
        List<string> list = new List<string>();
        Regex regex = new Regex(@"((?<=\p{Ll})\p{Lu}|\p{Lu}(?=\p{Ll}))");
        foreach (Match match in regex.Matches(s))
        {
            list.Add(match.Value);
        }
        return list.Count + 1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        int result = Result.camelcase(s);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}