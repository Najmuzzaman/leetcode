public class Solution {
    public int MaxCoins(int[] piles) {
        int n=piles.Length;
        Array.Sort(piles);
        int ans=0;
        int k=n/3;

        for(int i=n-2,j=0; i>=0 && j<k;i--,j++)
        {
            ans+=piles[n-((j+1)*2)];
        }
        return ans;
    }
}