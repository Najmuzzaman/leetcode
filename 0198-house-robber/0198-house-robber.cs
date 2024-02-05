public class Solution {
    public int Rob(int[] nums) {
        int r=0;
        int nr=0;
        int n=nums.Length;
        for(int i=0;i<n;i++)
        {
            int NR=nr+nums[i];
            int NNR=Math.Max(r,nr);
            r=NR;
            nr=NNR;
        }
        return Math.Max(r,nr);
    }
}