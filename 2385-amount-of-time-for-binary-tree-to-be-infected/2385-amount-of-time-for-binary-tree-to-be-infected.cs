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
    public class Pair {
        public int x;
        public int y;
        
        public Pair(int value1, int value2) {
            x = value1;
            y = value2;
        }
    }

    List<int>[] adj = new List<int>[100001];

    void dfs(TreeNode root) {
        if (root == null) return;
        int x = root.val;

        if (root.left != null) {
            int l = root.left.val;
            adj[x].Add(l);
            adj[l].Add(x);
            dfs(root.left);
        }

        if (root.right != null) {
            int r = root.right.val;
            adj[x].Add(r);
            adj[r].Add(x);
            dfs(root.right);
        }
    }
    public int AmountOfTime(TreeNode root, int start) {
        for (int i = 0; i < 100001; i++) {
            adj[i] = new List<int>();
        }

        dfs(root);

        bool[] viz = new bool[100001];
        Queue<Pair> q = new Queue<Pair>();
        q.Enqueue(new Pair(start, 0));
        viz[start] = true;
        int d = 0;
        while (q.Count > 0) {
            Pair current = q.Dequeue();
            int x = current.x;
            int dd = current.y;
            d = Math.Max(d, dd);
            foreach (int y in adj[x]) {
                if (viz[y]) continue;
                q.Enqueue(new Pair(y, dd + 1));
                viz[y] = true;
            }
        }

        return d;
    }
}