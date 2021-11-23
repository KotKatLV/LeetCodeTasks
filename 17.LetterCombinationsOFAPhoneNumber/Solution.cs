public class Solution
{
    private readonly Dictionary<char, List<char>> _buttons = new()
    {
        ['2'] = new List<char> { 'a', 'b', 'c' },
        ['3'] = new List<char> { 'd', 'e', 'f' },
        ['4'] = new List<char> { 'g', 'h', 'i' },
        ['5'] = new List<char> { 'j', 'k', 'l' },
        ['6'] = new List<char> { 'm', 'n', 'o' },
        ['7'] = new List<char> { 'p', 'q', 'r', 's' },
        ['8'] = new List<char> { 't', 'u', 'v' },
        ['9'] = new List<char> { 'w', 'x', 'y', 'z' },
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length <= 0)
        {
            return new List<string>();
        }

        List<string> result = new List<string>() { "" };
        foreach (var digit in digits)
        {
            var tmp = new List<string>();
            tmp.AddRange(_buttons.FirstOrDefault(x => x.Key == digit).Value.SelectMany(item => result.Select(s => s + item)));
            result = tmp;
        }

        return result;
    }
}