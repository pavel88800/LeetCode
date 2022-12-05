public class Solution {
    public  int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (target == nums[i])
            {
                return i;
            }
        }

        var newarray = new List<int>();
        newarray = nums.ToList();

        newarray.Add(target);
        newarray.Sort();
        var newa = newarray.ToArray();

        for (int i = 0; i < newa.Length; i++)
        {
            if (newa[i] == target)
            {
                return i;
            }
        }

        return 0;
    }
}
