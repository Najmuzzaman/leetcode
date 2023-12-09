/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> node=new List<int>();
        dfs(root,node);
        return node;
    }
    public void dfs(TreeNode root, List<int> node)
    {
        if(root!=null)
        {
            dfs(root.left,node);
            node.Add(root.val);
            dfs(root.right,node);
        }
    }
}