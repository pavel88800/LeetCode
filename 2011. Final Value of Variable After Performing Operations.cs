var s = new Solution();
Console.WriteLine(s.FinalValueAfterOperations(new [] {"X++","++X","--X","X--"}));

public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var result = 0;
        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "--X" or "X--":
                    result--;
                    break;
                case "X++" or "++X":
                    result++;
                    break;
                default:
                    continue;
            }
        }

        return result;
    }
}
