var s = new Solution();
Console.WriteLine(s.RunningSum(new[] { 1, 2, 3, 4 }));

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var index = 0;
        var sum =0;
        var newArray = new int[nums.Length];

        while (true)
        {
            if (index >= nums.Length) break;

            for (var i = 0; i <= index; i++)
            {
                sum += nums[i];
            }

            newArray[index] = sum;
            sum = 0;
            index++;
        }

        return newArray;
    }
}
