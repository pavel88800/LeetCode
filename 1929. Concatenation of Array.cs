var s = new Solution();
Console.WriteLine(s.GetConcatenation(new int[] { 1, 2, 3, 1 }));

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        var newarr = new int[nums.Length * 2];
        var lastIndex = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            if (lastIndex >= newarr.Length)
                break;
            
            if (i == nums.Length)
                i = 0;
            
            newarr[lastIndex] = nums[i];
            lastIndex ++;
        }

        return newarr;
    }
}
