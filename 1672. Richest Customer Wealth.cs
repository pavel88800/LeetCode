var s = new Solution();

var arr = new int[3][];
arr[0] = new int[5] { 1, 3, 5, 7, 9 };
arr[1] = new int[5] { 2, 1, 0, 7, 0 };
arr[2] = new int[5] { 1, 8, 5, 37, 17 };

Console.WriteLine(s.MaximumWealth(arr));

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var max = 0;
        var localMax = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            localMax = accounts[i].Sum();            

            if (localMax > max) 
                max = localMax;
            localMax = 0;
        }

        return max;
    }
}
