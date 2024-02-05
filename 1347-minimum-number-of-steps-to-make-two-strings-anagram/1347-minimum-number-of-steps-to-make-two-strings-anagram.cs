public class Solution {
    public int MinSteps(string s, string t) {
         int n = s.Length;
         int[] sl = new int[27];
         int[] tl = new int[27];
         for (int i = 0; i < n; i++)
         {
             sl[s[i] - 'a']++;
             tl[t[i] - 'a']++;
         }
         int ans = 0;
         for (int i = 0; i < 26; i++)
         {
             ans += Math.Abs(sl[i] - tl[i]);
         }
         return ans / 2;
    }
}