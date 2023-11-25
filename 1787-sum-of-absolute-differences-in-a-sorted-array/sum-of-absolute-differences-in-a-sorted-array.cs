public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int n=nums.Length;
        int[] result = new int[n];

        int leftSum = 0;
        int rightSum = nums.Sum();

        for (int i = 0; i < n; i++)
        {
            result[i] = i * nums[i] - leftSum + (rightSum - (n - i) * nums[i]);
            leftSum += nums[i];
            rightSum -= nums[i];
        }
        return result;
    }
}