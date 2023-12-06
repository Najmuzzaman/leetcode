public class Solution {
    public int TotalMoney(int n) {
        int ans = 0;
        int a = 1;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<7 && i<n ; j++,i++)
            {
                ans += (a + j);
            }
            a++;
            i--;
        }
        return ans;
    }
}