using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();

        var testInputDigit =
            "3-5";

        var outputResult = solution.MyAtoi(testInputDigit);
        Console.WriteLine(outputResult);
    }
}
/*********/
public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.TrimStart();

        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var positiveOrNegativeChar = ' ';
        for (var i = 0; i < s.Length; i++)
        {
            if (i is 0)
                switch (s[i])
                {
                    case '+':
                        if (positiveOrNegativeChar != '-')
                        {
                            positiveOrNegativeChar = '+';
                            continue;
                        }

                        positiveOrNegativeChar = '-';
                        continue;
                    case '-':
                        positiveOrNegativeChar = s[i];
                        continue;
                }
        }

        if (s.Contains("+-") || s.Contains("-+"))
        {
            return 0;
        }

        if (s.Contains("+ ") || s.Contains("- "))
        {
            return 0;
        }

        string ss;
        if (s[0] is '-' or '+')
        {
            ss = s.Substring(1, s.Length - 1).Trim();
        }
        else
        {
            ss = s;
        }

        var a = string.Empty;
        for (var i = 0; i < ss.Length; i++)
        {
            if (Regex.IsMatch(ss[i].ToString(), "\\d"))
            {
                a += ss[i];
            }
            else if (ss[i] is '-' or '+')
            {
                break;
            }
            else
            {
                break;
            }

            if (Regex.IsMatch(ss[i].ToString(), "\\."))
            {
                a += ss[i];
            }
        }

        if (string.IsNullOrEmpty(a))
        {
            return 0;
        }

        if (a.Contains('.'))
        {
            var split = a.Split(new[] { ',', '.' });
            a = split[0];

            if (string.IsNullOrEmpty(a))
            {
                return 0;
            }
        }

        var v = $"{positiveOrNegativeChar}{a}";
        if (int.TryParse(v, out var z))
        {
            return z;
        }

        if (v.Contains('-'))
        {
            return int.MinValue;
        }

        return int.MaxValue;
    }
}
