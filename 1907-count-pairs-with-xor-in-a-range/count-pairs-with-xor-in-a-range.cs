public class Solution {
    public class Node
    {
        public Node[] Links = new Node[2];
        public int Count = 0;
        public void Put(int ind, Node node)
        {
            Links[ind] = node;
        }
        public bool IsContains(int ind)
        {
            return Links[ind] != null;
        }
        public Node Get(int ind)
        {
            return Links[ind];
        }
        public void IncCount()
        {
            Count++;
        }
        public int GetCount()
        {
            return Count;
        }
    }
    public class Trie
    {
        public Node Root;

        public Trie()
        {
            Root = new Node();
        }

        public void Insert(int num)
        {
            Node node = Root;
            for (int i = 30; i >= 0; i--)
            {
                int bit = ((num >> i) & 1);
                if (!node.IsContains(bit))
                {
                    node.Put(bit, new Node());
                }
                node = node.Get(bit);
                node.IncCount();
            }
        }
        public int GetCount(Node root)
        {
            return root == null ? 0 : root.GetCount();
        }

        public int dfs(Node root, int index, int high, int val)
        {
            if (root == null) return 0;
            if (index < 0) return root.GetCount();

            int valBit = ((val >> index) & 1);
            int highBit = ((high >> index) & 1);

            if (valBit == 1)
            {
                if (highBit == 1) return dfs(root.Get(0), index - 1, high, val) + GetCount(root.Get(1));
                else return dfs(root.Get(1), index - 1, high, val);
            }
            else
            {
                if (highBit == 1) return dfs(root.Get(1), index - 1, high, val) + GetCount(root.Get(0));
                else return dfs(root.Get(0), index - 1, high, val);
            }
        }
    }


    public int CountPairs(int[] nums, int low, int high) {
      int ans = 0;
        Trie trie = new Trie();

        foreach (var num in nums)
        {
            ans += trie.dfs(trie.Root, 30, high, num);
            ans -= trie.dfs(trie.Root, 30, low - 1, num);
            trie.Insert(num);
        }

        return ans;
    }
}