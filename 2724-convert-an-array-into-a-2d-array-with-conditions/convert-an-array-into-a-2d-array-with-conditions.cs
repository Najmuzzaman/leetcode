public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        int n = nums.Length;
        // Count the frequency of each element in nums
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        // Determine the number of rows for the matrix
        int numRows = frequency.Max(kv => kv.Value);
        List<int>[] matrix = new List<int>[numRows];
        for (int i = 0; i < numRows;i++ )
            matrix[i] = new List<int>();
        // Initialize the matrix with the unique elements in nums
        foreach (var key in frequency.Keys)
        {
            int count = frequency[key];
            for (int i = 0; i < count; i++)
                matrix[i].Add(key);
        }
        return matrix.Cast<IList<int>>().ToList();
    }
}