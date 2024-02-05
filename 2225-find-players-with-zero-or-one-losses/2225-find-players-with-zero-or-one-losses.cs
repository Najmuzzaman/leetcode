public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        int n = matches.Length;
        int[] loss = new int[100001];
        for (int i = 0; i < n; i++)
        {
            int win = matches[i][0];
            int los = matches[i][1];
            if (loss[win] == 0)
                loss[win] = -1;

            if (loss[los] == -1)
                loss[los] = 1;
            else
                loss[los]++;
        }
        List<int> noLost = new List<int>();
        List<int> onelost = new List<int>();
        for (int i = 0; i < 100001; i++)
        {
            if (loss[i] == -1) noLost.Add(i);
            else if (loss[i] == 1) onelost.Add(i);
        }
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(noLost);
        result.Add(onelost);
        return result;
    }
}