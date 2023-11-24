public class Solution {
    public int FindMin(int[] nums) {
         int n=nums.Length;
        int mi=50000;
        for(int i=0;i<n;i++)
        {
            mi=Math.Min(mi,nums[i]);
        }
        return mi;
    }
}