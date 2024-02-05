public class Solution {
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int ans = 0;

        for (int l = 0; l < n; ++l)
        {
            int[] dp = new int[105];
            for (int k = l; k < n; ++k)
            {
                for (int i = 0; i < m; ++i)
                {
                    dp[i] += matrix[i][k];
                }
                for (int i = 0; i < m; ++i)
                {
                    int sum = 0;
                    for (int j = i; j < m; ++j)
                    {
                        sum += dp[j];
                        if (sum == target)
                        {
                            ++ans;
                        }
                    }
                }
            }
        }

        return ans;
    }
}