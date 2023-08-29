internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();

        var testInputDigit = -2147483648;

        var outputResult = solution.Reverse(testInputDigit);
        Console.WriteLine(outputResult);
    }
}
/**************/
public class Solution
{
    public int Reverse(int x)
    {
        if (x == 0 || x < int.MinValue || x > int.MaxValue)
        {
            return 0;
        }

        var charArray = x.ToString().Replace("-", "").Reverse().ToList();

        if (x < 0)
        {
            charArray.Insert(0, '-');
        }
        
        var reverseString = new string(charArray.ToArray());
        if (int.TryParse(reverseString, out var z))
        {
            return z;
        }

        return 0;
    }
}
