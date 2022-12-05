public class Solution {
     public  int LengthOfLastWord(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 1)
        {
            return 0;
        }

        s = s.Trim();

        var listWord = s.Split(' ');
        if (listWord.Count() == 1 && listWord[0] != " ")
        {
            return listWord[0].Length;
        }

        listWord = listWord.Where(x => x != " ").ToArray();

        var lastWord = listWord.Last();
        return lastWord.Length;
    }
}
