public class Solution {
    public int LongestBeautifulSubstring(string word) {
        int ans = 0;
        int n=word.Length;
        for (int i = 0, j = 0; i < n; ++i) {
            if (word[i] == 'a') {
                int cnt = 0;
                for (j = i + 1; j < n && word[j - 1] <= word[j]; ++j)
                    cnt +=  (word[j - 1] < word[j]?1:0);
                if (cnt == 4)
                    ans = Math.Max(ans, j - i);
                i = j - 1;
            }
        }
        return ans;
    }
}