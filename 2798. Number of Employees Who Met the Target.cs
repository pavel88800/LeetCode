var s = new Solution();
Console.WriteLine(s.NumberOfEmployeesWhoMetTarget(new[] { 2, 5, 1, 3, 4, 7 }, 3));

public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Where(x => x >= target).Count();
    }
}

public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Where(x => x >= target).Count();
    }
}


public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        var count = 0;
        for (int i = 0; i < hours.Length; i++)
        {
            if (hours[i] >= target)
            {
                count++;
            }
        }

        return count;
    }
}
