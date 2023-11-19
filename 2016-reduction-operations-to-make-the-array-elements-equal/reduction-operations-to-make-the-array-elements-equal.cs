public class Solution {
    public int ReductionOperations(int[] nums) {
        Array.Sort(nums);
        Dictionary<int, int> d = new Dictionary<int, int>();
        int n = nums.Length;
        for(int i=0;i<n;i++)
        {
            if(d.ContainsKey(nums[i]))
                d[nums[i]]++;
            else
                d[nums[i]]=1;
        }
        int cnt = 0;
        int j=0;
        foreach(var dec in d)
        {
            cnt += (j * dec.Value);
            j++;
        }
        return cnt;
    }
}