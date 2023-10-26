var s = new Solution();
Console.WriteLine(s.Shuffle(new[] { 2, 5, 1, 3, 4, 7 }, 3));

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var list = new List<int>();
        
        for (var i = 0; i < n; i++)
        {
            if (n >= nums.Length) break;
            
            for (var j = n; j < nums.Length; j++)
            {
                list.AddRange(new[] { nums[i], nums[j] });
                n++;
                break;
            }
        }

        return list.ToArray();
    }
}
