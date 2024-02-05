public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        int[] index=new int[2001];
        int[] ind=new int[2001];
        int n=arr.Length;
        for(int i=0;i<n;i++)
        {
            index[arr[i]+1000]++;
        }
        for(int i=0;i<=2000;i++)
        {
            if(index[i]>0)
            {
                if(ind[index[i]]==1) return false;
                ind[index[i]]=1;
            }
        }
        return true;
    }
}