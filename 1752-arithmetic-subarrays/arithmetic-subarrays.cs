public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        List<bool> result = new List<bool>();
        List<int> num = new List<int>(nums);
        for (int i = 0; i < l.Length; i++)
        {
            int start = l[i], end = r[i];
            List<int> subarray = new List<int>(num.GetRange(start, end - start + 1));


            // Sort the subarray to check for arithmetic sequence
            subarray.Sort();

            int diff = subarray[1] - subarray[0];
            bool isArithmetic = true;
            for (int j = 1; j < subarray.Count-1; j++)
            {
                int di = subarray[j + 1] - subarray[j];
                if (di != diff)
                {
                    isArithmetic = false;
                    break;
                }
            }
            result.Add(isArithmetic);
        }
        return result;
    }
}