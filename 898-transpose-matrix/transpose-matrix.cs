public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int n=matrix.Length;
        int m=matrix[0].Length;
        int[][] trns = new int[m][];
        for(int i=0;i<m;i++)
        {
            trns[i]=new int[n];
            for(int j=0;j<n;j++)
            {
                trns[i][j]=matrix[j][i];
            }
        }
        return trns;
    }
}