var s = new Solution();

var grid = new int[4][]
    { new[] { 4, 3, 2, -1 }, new[] { 3, 2, 1, -1 }, new[] { 1, 1, -1, -2 }, new[] { -1, -1, -2, -3 } };


Console.WriteLine(s.CountNegatives(grid));

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        var count = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] < 0) count++;
            }
        }
      
        return count;
    }
}

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        var list = new List<int>();
        for (var i = 0; i < grid.Length; i++)
        {
            list.AddRange(grid[i]);
        }
        return list.Where(x=>x < 0).Count();
    }
}
