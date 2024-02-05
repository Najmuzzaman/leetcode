public class Solution {
    int maxLength;
    public int MaxLength(IList<string> arr) {
        maxLength = 0;
        dfs(arr, "", 0);
        return maxLength;
    }
    private void dfs(IList<string> arr, string current, int start) {
        if (maxLength < current.Length)
            maxLength = current.Length;

        for (int i = start; i < arr.Count; i++) {
            if (!IsValid(current, arr[i]))
                continue;

            dfs(arr, current + arr[i], i + 1);
        }
    }

    private bool IsValid(string currentString, string newString) {
        HashSet<char> charSet = new HashSet<char>();

        foreach (char ch in newString) {
            if (charSet.Contains(ch)) {
                return false;
            }

            charSet.Add(ch);

            if (currentString.Contains(ch.ToString())) {
                return false;
            }
        }

        return true;
    }
}