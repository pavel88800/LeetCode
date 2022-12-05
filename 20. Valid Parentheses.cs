public class Solution {
    public  bool IsValid(string s)
    {
      var dict = new Dictionary<char, char> {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        if (s.Length % 2 != 0)
        {
            return false;
        }

        var s1 = s;
        var strLength = 1;

        do
        {
            for (int i = 0; i < s1.Length - 1; i++)
            {
                foreach (var item in dict)
                {
                    if (s1[i] == item.Key && s1[i + 1] == item.Value)
                    {
                        s1 = s1.Replace(new string(new char[] { s1[i], s1[i + 1] }), "");
                        break;
                    }
                }
            }

            if (strLength > s.Length && s1 != string.Empty)
            {
                return false;
            }

            if (s1 == string.Empty)
            {
                return true;
            }
            strLength++;
        } while (true);
    }
}
