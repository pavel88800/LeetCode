using System.Text;

var s = new Solution();
Console.WriteLine(s.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv"));

public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        var startCharIndex = 97;
        var endCharIndex = 122;
        var dictionaryCharTable = new Dictionary<char, char>();

        for (var i = 0; i < key.Length; i++)
        {
            if (startCharIndex > endCharIndex)
            {
                break;
            }

            if (!char.IsWhiteSpace(key[i]) && dictionaryCharTable.TryAdd(key[i], (char)startCharIndex))
            {
                startCharIndex++;
            }
        }

        var sb = new StringBuilder();
        for (var i = 0; i < message.Length; i++)
        {
            if (char.IsWhiteSpace(message[i]))
            {
                sb.Append(message[i]);
                continue;
            }

            sb.Append(dictionaryCharTable[message[i]]);
        }

        return sb.ToString();
    }
}
