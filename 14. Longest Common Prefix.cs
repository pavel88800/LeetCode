using System.Text.RegularExpressions;

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
       if (strs.Length < 1 || strs.First() == "")
            return "";

        string firstWord = strs[0];
        string prefix = string.Empty;
        int countChars = 1;
        string testprefix = firstWord.Substring(0, countChars);
        int countOfMatches = 0;

        do
        {
            foreach (var word in strs)
            {
                if (!Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                {
                    break;
                }

                if (testprefix.Equals(word.Substring(0, countChars)))
                {
                    countOfMatches++;
                }
            }

            if (countOfMatches == strs.Length)
            {
                if (strs.Any(x => x.Length <= countChars))
                {
                    prefix = testprefix;
                    continue;
                }

                countChars++;
                prefix = testprefix;
                testprefix = firstWord.Substring(0, countChars);
                countOfMatches = 0;
            }
            else
            {
                countChars = 0;
                break;
            }

        } while (true);

        return prefix;
    }
}
