var node5 = new TreeNode(5);
var node4 = new TreeNode(4, null);
var node3 = new TreeNode(3, null);
var node2 = new TreeNode(2, node4, node5);
var node1 = new TreeNode(1, node2, node3);

var s = new Solution();
var res = s.CountNodes(node1);


public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var count = 0;
        if (root is not null)
        {
            stack.Push(root);
            count = 1;
        }
        
        while (stack.Count > 0)
        {
            var treeNode = stack.Pop();
            
            if (treeNode.left is not null)
            {
                stack.Push(treeNode.left);
                count++;
            }
            if (treeNode.right is not null)
            {
                stack.Push(treeNode.right);
                count++;
            }
        }

        return count;
    }
}
