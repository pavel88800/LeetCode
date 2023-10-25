var s = new Solution();
Console.WriteLine(s.AddDigits(38));

public class Solution
{
    public int AddDigits(int num)
    {
        var stack = new Stack<int>();
        stack.Push(num);
        var resultDigit = 0;
        while (stack.Any())
        {
            var ourNumber = stack.Pop();
            if (ourNumber >= 10)
            {
                var chars = ourNumber.ToString().ToCharArray();
                var s = 0;
                for (var i = 0; i < chars.Length; i++)
                {
                    s += chars[i] - '0';
                }

                if (s >= 10)
                {
                    stack.Push(s);
                    continue;
                }

                resultDigit = s;
                break;
            }

            resultDigit = ourNumber;
            break;
        }

        return resultDigit;
    }
}
