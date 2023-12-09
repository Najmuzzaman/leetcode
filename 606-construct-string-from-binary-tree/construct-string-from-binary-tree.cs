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
    public string node="";
    public string Tree2str(TreeNode root) {
     
        dfs(root);      
        return node;
    }
    public void dfs(TreeNode root)
    {   
        if(root!=null)
        {
            node+=root.val.ToString();
            if(root.left!=null || root.right!=null)
            {
                node+="(";
                dfs(root.left);
                 node+=")";
            }
            if(root.right!=null)
            {
                node+="(";
                dfs(root.right);
                node+=")";
            }
        }
    }
}