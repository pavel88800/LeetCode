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
public class Solution {
    public  ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if(list1 == null && list2 == null)
            return null;
        
        var c1 = list1;
        var c2 = list2;
        var lll = new ListNode();

        var a = Unlink(list1);
        var b = Unlink(list2);


        var c = a.Union(b).OrderBy(x => x.val).ToList();
        return  Linked(c);
    }

    private  List<ListNode> Unlink(ListNode node)
    {
        if(node == null)
            return new  List<ListNode>();
        
        var listListNode = new List<ListNode>();

        listListNode.Add(node);
        
        if (node.next != null)
            listListNode.AddRange(Unlink(node.next));
        
        return listListNode;
    }

    private  ListNode Linked(List<ListNode> listListNode)
    {

        if (listListNode.Count == 0)
            return null;

        for (int i = 0; i < listListNode.Count - 1; i++)
            listListNode[i].next = listListNode[i + 1];

        return listListNode[0];

    }
}
