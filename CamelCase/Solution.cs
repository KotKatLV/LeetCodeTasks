using System.Text.RegularExpressions;

class Result
{
    private static readonly string _numbers = "0123456789";
    private static readonly string _lower_case = "abcdefghijklmnopqrstuvwxyz";
    private static readonly string _upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly string _special_characters = "!@#$%^&*()-+";
    private static readonly int _minPassLenght = 6;

    public static int minimumNumber(int passwordLength, string password)
    {
        int result = 0;
        if (password.IndexOfAny(_numbers.ToCharArray()) == -1)
        {
            ++result;
        }

        if (password.IndexOfAny(_lower_case.ToCharArray()) == -1)
        {
            ++result;
        }

        if (password.IndexOfAny(_upper_case.ToCharArray()) == -1)
        {
            ++result;
        }

        if (password.IndexOfAny(_special_characters.ToCharArray()) == -1)
        {
            ++result;
        }

        if (result < _minPassLenght && passwordLength < _minPassLenght && result + passwordLength < _minPassLenght)
        {
            result += _minPassLenght - result - passwordLength;
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    { 
        Console.WriteLine(Result.minimumNumber(4, "4700"));
        Console.ReadLine();
    }
}