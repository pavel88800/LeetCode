var s = new Solution();
s.NumIdenticalPairs(new int[] { 1,1,1,1 });

public class Solution {
    public int NumIdenticalPairs(int[] nums)
    {
        var numIdenticalPairs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    numIdenticalPairs++;
                }
            }
        }
        
        return numIdenticalPairs;
    }
}
