var n = 3;
var s = new Solution();
Console.WriteLine(s.IsPowerOfTwo(n));

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        for (var i = 0; i < n; i++)
        {
            var pow = Math.Pow(2, i); 
            if (n < pow)
            {
                break;
            }

            if (n == pow)
            {
                return true;
            }
        }

        return false;
    }
}
