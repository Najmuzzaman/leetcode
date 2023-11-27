public class Solution {
    int mod = 1000000007;
    List<List<int>> v = new List<List<int>>
    {
        new List<int> { 4, 6 },//0
        new List<int> { 6, 8 },//1
        new List<int> { 7, 9 },//2
        new List<int> { 4, 8 },//3
        new List<int> { 0, 3, 9 },//4
        new List<int>(),//5
        new List<int> { 1, 7, 0 },//6
        new List<int> { 2, 6 },//7
        new List<int> { 1, 3 },//8
        new List<int> { 4, 2 }//9
    };
    int[][] arr = new int[10][];
    int dfs(int ind,int n)
    {
        if(n==1) return 1;
        if(arr[ind][n]!=-1) return arr[ind][n];
        int ans=0;
        for(int i=0;i<v[ind].Count;i++)
        {
            ans+=dfs(v[ind][i],n-1)%mod;
            ans%=mod;
        }
        return arr[ind][n]=ans%mod;
    }

    public int KnightDialer(int n) {
            for (int i = 0; i < 10; i++ )
            {
                arr[i]=new int[n+1];
                for(int j=0;j<=n;j++)
                {
                    arr[i][j] = -1;
                }
            }
            int ans = 0;
            for (int i = 0; i < 10; i++)
            {
                ans = (ans + dfs(i, n) % mod) % mod;
            }
            return ans % mod;
    }
}