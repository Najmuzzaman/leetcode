public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int time = 0;
        int n = garbage.Length;
        int mtime = 0;
        int ptime = 0;
        int gtime = 0;
        for (int i = 0; i < n; i++)
        {
            int m = 0;
            int p = 0;
            int g = 0;
            if (i != 0)
            {
                mtime += travel[i - 1];
                ptime += travel[i - 1];
                gtime += travel[i - 1];
            }
            int l = garbage[i].Length;
            for (int j = 0; j < l; j++)
            {
                if (garbage[i][j] == 'M') m++;
                else if (garbage[i][j] == 'P') p++;
                else g++;
            }
            if(g>0)
            {
                time += (g + gtime);
                gtime = 0;
            }
            if(m>0)
            {
                time += (m + mtime);
                mtime = 0;
            }
            if (p > 0)
            {
                time += (p + ptime);
                ptime = 0;
            }
        }
        return time;
    }
}