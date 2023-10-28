var s = new Solution();
var nums = new[] { 1, 2, 3, 4 };
var a = s.MaxProduct(nums);

Console.ReadLine();

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var max = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var res = (nums[i] - 1) * (nums[j] - 1);
                if (res > max)
                {
                    max = res;
                }
            }
        }

        return max;
    }
}
