class Program
{
    static void Main(string[] args)
    {
        var node5 = new ListNode(5);
        var node4 = new ListNode(4, node5);
        var node3 = new ListNode(3, node4);
        var node2 = new ListNode(2, node3);
        var node1 = new ListNode(1, node2);

        var s = new Solution();
        var res = s.RemoveNthFromEnd(node1, 1);
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var list = Unlinked(head);

        //var list = list;
        var m = 0;
        for (int i = list.Count - 1; i >= 0; i--)
        {
            m++;

            if (m == n)
            {
                list.Remove(list[i]);
                break;
            }
        }

        if (list.Any())
        {
            list.Last().next = null;
        }
        return Linked(list);
    }

    private List<ListNode> Unlinked(ListNode node)
    {
        if (node is null)
        {
            return new List<ListNode>();
        }

        var newListNode = new List<ListNode> { node };

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
}
