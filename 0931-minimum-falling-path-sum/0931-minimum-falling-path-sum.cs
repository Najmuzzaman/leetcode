public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        int n = matrix.Length;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] += Math.Min(matrix[i - 1][Math.Max(0, j - 1)], Math.Min(matrix[i - 1][j],matrix[i - 1][Math.Min(n - 1, j + 1)]));
            }
        }
        return matrix[n - 1].Min();
    }
}