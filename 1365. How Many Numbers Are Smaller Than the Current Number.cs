var s = new Solution();
Console.WriteLine(s.SmallerNumbersThanCurrent(new[] { 8,1,2,2,3 }));

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var arr = new int[nums.Length ];
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            arr[i] =  0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i && nums[j] < nums[i])
                {
                    count++;
                    arr[i] = count;
                }
            }
            count = 0;
        }

        return arr;
    }
}

public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var arr = new int[nums.Length];
        var count = 0;
        var left = 0;
        var right = 0;

        while (true)
        {
            if (left == right)
            {
                right++;
                continue;
            }

            if (right > nums.Length - 1)
            {
                left++;
                
                if (left > nums.Length - 1)
                    break;
                
                right = 0;
                count = 0;
                continue;
            }

            if (nums[left] > nums[right])
            {
                count++;
                arr[left] = count;
            }

            right++;
        }

        return arr;
    }
}
