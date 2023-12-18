public class Solution {
    public int MaxProductDifference(int[] nums) {
        int n=nums.Length;
        Array.Sort(nums);
        return (nums[n - 1] * nums[n - 2])-(nums[0] * nums[1]) ;
    }
}