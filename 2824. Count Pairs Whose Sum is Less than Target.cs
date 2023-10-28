var s = new Solution();
Console.WriteLine(s.CountPairs(new[] { -1, 1, 2, 3, 1 }, 2));

public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        var count = 0;

        for (var i = 0; i < nums.Count; i++)
        {
            for (var j = i + 1; j < nums.Count; j++)
            {
                if (i < j && nums[i] + nums[j] < target)
                    count++;
            }
        }

        return count;
    }
}
