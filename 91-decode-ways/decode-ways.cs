public class Solution {
    public int NumDecodings(string s) {
        int n=s.Length;
        int dp = 1;
        int dp1 = 0;
        if (s[0] == '0') return 0;
        for(int i=n-1;i>=0;i--)
        {
            int a= s[i] == '0'?0:dp;
            if (i < n - 1 && (s[i] == '1' || (s[i] == '2' && s[i + 1] < '7')))
                a += dp1;
            dp1 = dp;
            dp = a;
        }
        return dp;
    }
}