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
     void dfs(TreeNode root, List<int> leafValues) {
        if (root == null) {
            return;
        }
        if (root.left == null && root.right == null) {
            leafValues.Add(root.val);
        }
        dfs(root.left, leafValues);
        dfs(root.right, leafValues);
    }
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> first = new List<int>();
        List<int> second = new List<int>();
        dfs(root1, first);
        dfs(root2, second);
        return Enumerable.SequenceEqual(first,second);
    }
}