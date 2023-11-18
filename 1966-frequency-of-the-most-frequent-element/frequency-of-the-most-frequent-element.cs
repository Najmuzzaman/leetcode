public class Solution {
    public int MaxFrequency(int[] nums, int k) {
         Array.Sort(nums);
        int n = nums.Length;
        int maxFrequency = 1;
        int left = 0;
        long sum = 0;
        for (int i = 0; i < n;i++)
        {
            sum += nums[i];            
            while ((long)nums[i] * (i - left + 1) > sum + k) {
                sum -= nums[left];
                left++;
            }            
            maxFrequency = Math.Max(maxFrequency, i - left + 1);
        }
        return maxFrequency;

    }
}