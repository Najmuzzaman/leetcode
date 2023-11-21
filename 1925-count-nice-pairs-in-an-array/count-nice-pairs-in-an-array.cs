public class Solution {
    public int reverse(int n)
    {
        int a=0;
        while(n!=0)
        {
            a=a*10+n%10;
            n/=10;
        }
        return a;
    }
    public int CountNicePairs(int[] nums) {
        int mod = 1000000007;
        Dictionary<long, int> list = new Dictionary<long, int>();
        int n = nums.Length;
        for(int i=0;i<n;i++)
        {
            long a = nums[i] - reverse(nums[i]);
            if (list.ContainsKey(a))
                list[a]++;
            else
                list[a] = 1;
        }
        long cnt = 0;
        foreach(var v in list)
        {
            long a = v.Value;
            cnt = (cnt + a*(a - 1)/2) % mod;
        }
        return (int)cnt;
    }
}