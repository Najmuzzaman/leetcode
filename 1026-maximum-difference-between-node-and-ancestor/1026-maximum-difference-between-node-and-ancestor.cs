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
    private int[] dfs(TreeNode root, int[] m) {
        if (root == null)
        {
            return new int[] { int.MaxValue, int.MinValue };
        }

        int[] left = dfs(root.left, m);
        int[] right = dfs(root.right, m);

        int minVal = Math.Min(root.val, Math.Min(left[0], right[0]));
        int maxVal = Math.Max(root.val, Math.Max(left[1], right[1]));

        m[0] = Math.Max(m[0], Math.Max(Math.Abs(minVal - root.val), Math.Abs(maxVal - root.val)));

        return new int[] { minVal, maxVal };
    }
    public int MaxAncestorDiff(TreeNode root) {
        int[] m={0};
        dfs(root,m);
        return m[0];
    }
}