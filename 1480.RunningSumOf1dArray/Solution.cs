// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public static class Solution
{
    private static int _startValue;

    public static void Main()
    {
        Console.WriteLine(FinalValueAfterOperations(new string[] { "++X", "++X", "X++" }));
        Console.ReadKey();
    }

    public static int FinalValueAfterOperations(string[] operations)
    {
        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "++X": ++_startValue; break;
                case "--X": --_startValue; break;
                case "X++": _startValue++; break;
                case "X--": _startValue--; break;
            }
        }
        return _startValue;
    }
}