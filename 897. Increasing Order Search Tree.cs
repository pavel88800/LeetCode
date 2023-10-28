var s = new Solution();
var tree = new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1, null)), new TreeNode(4, null)),
    new TreeNode(6, null, new TreeNode(8, new TreeNode(7), new TreeNode(9))));

s.IncreasingBST(tree);


 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 
public class Solution {
    public TreeNode IncreasingBST(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        var treeNodes = new List<TreeNode>();
        while (stack.Any())
        {
            var node = stack.Pop();
            treeNodes.Add(new TreeNode(node.val));
            
            if (node.left is not null)
            {
                stack.Push(node.left);
            }
            
            if (node.right is not null)
            {
                stack.Push(node.right);
            }
        }

        treeNodes = treeNodes.OrderBy(x => x.val).ToList();

        for (int i = 0; i < treeNodes.Count(); i++)
        {
            if (i + 1 >= treeNodes.Count) break;
            treeNodes[i].right = treeNodes[i + 1];
        }

        var newTreeNode = treeNodes[0];
        treeNodes = new List<TreeNode>();
        return newTreeNode;
    }
}
