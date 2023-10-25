var s = new Solution();

var root = new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1, new ListNode(0, null))))));
Console.WriteLine(s.IsPalindrome(root));


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

public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        var stack = new Stack<ListNode>();
        var list = new List<int>();
        
        if (head is not null)
        {
            stack.Push(head);
        }

        while (stack.Any())
        {
            var listNode = stack.Pop();
            list.Add(listNode.val);
            
            if (listNode.next is not null)
            {
                stack.Push(listNode.next);
            }
        }

        var IsPalindrome = false;
        for (int i = 0, j = list.Count - 1; i < list.Count; i++, j--)
        {
            if (list[i] == list[j])
            {
                IsPalindrome = true;
                continue;
            }

            return false;
        }
        
       return IsPalindrome;
    }
}
