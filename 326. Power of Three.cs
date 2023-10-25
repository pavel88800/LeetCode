var s = new Solution();
Console.WriteLine(s.IsPowerOfThree(0));

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
            return false;
        
        var log = Math.Round(Math.Log(n, 3));

        if (n == Math.Pow(3, log))
            return true;

        return false;
    }
}
