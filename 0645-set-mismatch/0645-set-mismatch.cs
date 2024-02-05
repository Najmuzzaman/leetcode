public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int n=nums.Length;
        int[] fre=new int[n+1];
        int[] num_error = new int[2];
        for(int i=0;i<n;i++)
        {
            if(fre[nums[i]]==1)
            {
                num_error[0]=nums[i];
            }
            fre[nums[i]]=1;
        }
        for(int i=1;i<=n;i++)
        {
            if(fre[i]==0)
            {
                num_error[1]=i;
                break;
            }
        }        
        return num_error;
    }
}