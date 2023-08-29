/********************/
internal class Program
{
    private static void Main(string[] args)
    {
        var newSolution = new Solution();
        var n3 = new ListNode(3);
        var n2 = new ListNode(2, n3);
        var n1 = new ListNode(1, n2);

        var n6 = new ListNode(3);
        var n5 = new ListNode(2, n6);
        var n4 = new ListNode(1, n5);
        var a = newSolution.AddTwoNumbers(n1, n4);
    }
}
/********************/
public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
/********************/
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var firstListNodes = Unlinked(l1);
        var secondListNodes = Unlinked(l2);

        var fistDigitString = string.Join("", firstListNodes.Select(x => x.val));
        var secondDigitString = string.Join("", secondListNodes.Select(x => x.val));
        var plusStrings = PlusStrings(fistDigitString, secondDigitString);

        return Linked(plusStrings.ToList());
    }

    private List<ListNode> Unlinked(ListNode node)
    {
        if (node is null)
        {
            return new List<ListNode>();
        }

        var newListNode = new List<ListNode>();
        newListNode.Add(node);

        if (node.next is not null)
        {
            newListNode.AddRange(Unlinked(node.next));
        }

        return newListNode;
    }

    private ListNode Linked(List<ListNode> listListNode)
    {
        if (listListNode.Count == 0)
        {
            return null;
        }

        for (var i = 0; i < listListNode.Count - 1; i++)
        {
            listListNode[i].next = listListNode[i + 1];
        }

        return listListNode[0];
    }

    private IEnumerable<ListNode> PlusStrings(string s1, string s2)
    {
        int c, d = 0;
        var resString = string.Empty;
        var maxLengthString = Math.Max(s1.Length, s2.Length);

        if (s1.Length > s2.Length)
        {
            s2 = s2.PadRight(maxLengthString, '0');
        }
        else
        {
            s1 = s1.PadRight(maxLengthString, '0');
        }

        for (var i = 0; i < maxLengthString; i++)
        {
            var firstDigit = s1[i] - '0';
            var secondDigit = s2[i] - '0';
            var sum = firstDigit + secondDigit;

            c = GetLastDigit(sum);

            if (sum < 9)
            {
                if (d > 0)
                {
                    c += d;
                    d = 0;
                }
            }
            else if (sum <= 9)
            {
                if (d > 0)
                {
                    c += d;
                    c = GetLastDigit(c);
                    d = 1;
                }
            }
            else
            {
                if (d > 0)
                {
                    c += d;
                }

                d = 1;
            }

            resString += c;
        }

        if (d > 0)
        {
            resString += d;
        }

        return resString.Select(x => new ListNode(x - '0'));
    }

    private int GetLastDigit(int d) => d % 10;
}
