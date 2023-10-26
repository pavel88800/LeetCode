var s = new Solution();
Console.WriteLine(s.StrStr("leetcode", "leeto"));

public class Solution {
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}
