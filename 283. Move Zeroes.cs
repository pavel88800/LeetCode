var nums = new int[] { 1, 2, 0, 3, 12 };
var s = new Solution();
s.MoveZeroes(nums);

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var left = 0;
        var right = left + 1;

        while (true)
        {
            if (right > nums.Length - 1)
                break;
            
            if ((nums[left] != 0 && nums[right] == 0) || (nums[left] != 0 && nums[right] != 0))
            {
                left++;
                right++;
                continue;
            }

            if (nums[left] == 0 && nums[right] != 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right++;
                continue;
            }

            if (nums[left] == 0 && nums[right] == 0)
            {
                right++;
            }
        }
    }
}
