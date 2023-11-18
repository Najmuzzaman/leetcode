public class Solution {
    public int[] CountBits(int n) {
        int[] arr=new int[n+1];
        arr[0]=0;
        for(int i=1;i<=n;i++)
        {
            arr[i]=arr[i/2]+ (i&1);
        }
        return arr;
    }
}