public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] ans = new int[n];
        Stack<int> st = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            while (st.Count != 0 && temperatures[st.First()] < temperatures[i])
            {
                ans[st.First()] = i - st.First();
                st.Pop();
            }
            st.Push(i);
        }
        return ans;
    }
}