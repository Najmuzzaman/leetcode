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
    public int PseudoPalindromicPaths (TreeNode root) {
        return Dfs(root,0);
    }
    
    public int Dfs(TreeNode root, int mask)
    {
        if (root == null)
        {
            return 0;
        }

        mask ^= 1 << root.val;

        if (root.left == null && root.right == null)
        {
            return (mask & (mask - 1)) == 0 ? 1 : 0;
        }

        return Dfs(root.left, mask) + Dfs(root.right, mask);
    }
}