using System.Text.RegularExpressions;

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    private static readonly int _countLettersInLatinAlphabet = 26;
    public static string pangrams(string s) => Regex.Replace(s, @"\s+", "").ToLower().ToCharArray().Distinct().Count() == _countLettersInLatinAlphabet ? "pangram" : "not pangram";

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}