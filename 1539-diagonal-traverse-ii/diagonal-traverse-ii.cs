public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        Dictionary<int, List<int>> l = new Dictionary<int, List<int>>();
        List<int> list = new List<int>();

         for (int row = nums.Count - 1; row >= 0; row--) 
         {
            for (int col = 0; col < nums[row].Count; col++) 
            {
                int ind = row + col;
                if (!l.ContainsKey(ind))
                {
                    l[ind] = new List<int>();
                }
                l[ind].Add(nums[row][col]);
            }
        }
        int i = 0;
        while (l.ContainsKey(i))
        {
            list.AddRange(l[i]);
            i++;
        }
        return list.ToArray();
    }
}