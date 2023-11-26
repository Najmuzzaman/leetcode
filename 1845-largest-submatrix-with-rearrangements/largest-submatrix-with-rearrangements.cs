public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int ans = 0;
        int[] currRow =new int[n];
        Array.Copy(matrix[0], currRow, n); 
        Array.Sort(currRow);
        Array.Reverse(currRow);
        for (int i = 0; i < n; i++)
        {
            ans = Math.Max(ans, currRow[i] * (i + 1));
        }
        for (int row = 1; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row][col] == 1 && row > 0)
                {
                    matrix[row][col] += matrix[row - 1][col];
                }
            }
            currRow =new int[n];
            Array.Copy(matrix[row], currRow, n); 
            Array.Sort(currRow);
            Array.Reverse(currRow);
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, currRow[i] * (i + 1));
            }
        }
        return ans;
    }
}