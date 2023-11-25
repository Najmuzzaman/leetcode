public class Solution {
    public int MaxProduct(int[] nums) {
        int n=nums.Length;
        int maxproduct=nums[0];
        int pro=1;
        for(int i=0;i<n;i++)
        {
            pro*=nums[i];
            if(pro>maxproduct)
            {
                maxproduct=pro;
            }
            if(pro==0)
                 pro=1;
        }
        pro=1;
        for(int i=n-1;i>=0;i--)
        {
            pro*=nums[i];
            if(pro>maxproduct)
            {
                maxproduct=pro;
            }
            if(pro==0)
                pro=1;
        }
        return maxproduct;
    }
}