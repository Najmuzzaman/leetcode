public class Solution {
    public bool CloseStrings(string word1, string word2) {
        int[] first = new int[26];
        int[] second = new int[26];
        int n=word1.Length;
        int m=word2.Length;
        for (int i = 0; i < n; ++i) {
            first[word1[i]-'a']++;
        }

        for (int i = 0; i <m; ++i) {
            second[word2[i]-'a']++;
        }

        for (int i = 0; i < 26; ++i) {
            if ((first[i] > 0 && second[i] == 0) || (second[i] > 0 && first[i] == 0)) {
                return false; 
            }
        }

        Array.Sort(first);
        Array.Sort(second);

        for (int i = 0; i < 26; ++i) {
            if (first[i] != second[i]) {
                return false; 
            }
        }
        return true;
    }
}