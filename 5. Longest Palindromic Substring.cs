internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();


        var testString =
            "borcdubqiupahpwjizjjbkncelfazeqynfbrnzuvbhjnyvrlkdyfyjjxnprfocrmisugizsgvhszooktdwhehojbrdbtgkiwkhpfjfcstwcajiuediebdhukqnroxbgtvottummbypokdljjvnthcbesoyigscekrqswdpalnjnhcnqrarxuufzzmkwizptyvjhpfidgmskuaggtpxqisdlyloznkarxofzeeyvteynluofuhbllyiszszbwnsglqjkignusarxsjvctpgiwnhdufmfpanfwxjwlmhgllzsmdpncbwnsbdtsvrjybynifywkulqnzprcxockbhrhvnwxrkvwumyieazclcviumvormynbryaziijpdinwatwqppamfiqfiojgwkvfzyxadyfjrgmtttvlgkqghgbcfhkigfojjkhskzenlpasyozcsuccdxhulcubsgomvcrbqwakrraesfifecmoztayrdjicypakrrneulfbqqxtrdelggedvloebqaztmfyfkhuonrognejxpesmwgnmnnnamvkxqvzrgzdqtvuhccryeowywmbixktnkqnwzlzfvloyqcageugmjqihyjxhssmhkfzxpzxmgpjgsduogfolnkkqizitbvvgrkczmojxnabruwwzxxqcevdwvtiigwckpxnnxxxdhxpgomncttjutrsvyrqcfwxhexhaguddkiesmfrqfjfdaqbkeqinwicphktffuwcazlmerdhraufbpcznbuipmymipxbsdhuesmcwnkdvilqbnkaglloswcpqzdggnhjdkkumfuzihilrpcvemwllicoqiugobhrwdxtoefynqmccamhdtxujfudbglmiwqklriolqfkknbmindxtljulnxhipsieyohnczddabrxzjmompbtnnxvivmoyfzfrxlu";

        var lengthString = solution.LongestPalindrome(testString);
        Console.WriteLine(lengthString);
    }
}

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 1)
        {
            return s;
        }

        if (s[0] == s[^1] && s == new string(s.Reverse().ToArray()))
        {
            return s;
        }

        var longestPalindromicSubstring = string.Empty;
        string subString;
        var i = 0;
        var sLength = s.Length - 1;
        do
        {
            for (var j = 0; j < s.Length; j++)
            {
                if (i + j > sLength)
                {
                    subString = s.Substring(i);
                    if (subString.Length <= longestPalindromicSubstring.Length)
                        continue;
                }
                else
                {
                    subString = s.Substring(i, j);
                    if (subString.Length <= longestPalindromicSubstring.Length)
                        continue;
                }

                if (subString[0] == subString[^1])
                {
                    if (subString.Equals(new string(subString.Reverse().ToArray())))
                    {
                        longestPalindromicSubstring = subString;
                    }
                }
            }

            i++;
        } while (i < s.Length);

        return longestPalindromicSubstring;
    }
}
