var s = new Solution();
Console.WriteLine(s.FirstUniqChar("aabb"));

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var arr = s.ToCharArray();
        var queue = new Queue<char>(arr);
        var lookup = arr.ToLookup(x=>x);
        var index = -1;
        
        while (queue.Any())
        {
            var peek = queue.Peek();
            
            if (lookup[peek].Count() > 1)
            {
                queue.Dequeue();
                continue;
            }

            index = s.IndexOf(peek);
            break;
        }

        return index >= 0 ? index : -1;
    }
}
