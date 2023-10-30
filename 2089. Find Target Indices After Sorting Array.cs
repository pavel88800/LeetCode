var s = new Solution();

Console.WriteLine(s.TargetIndices(new[] { 1, 2, 5, 2, 3 }, 2));

public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        var listIndexes = new List<int>(nums.Length);
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                listIndexes.Add(i);
            }
        }

        return listIndexes;
    }
}
