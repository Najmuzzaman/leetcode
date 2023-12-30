public class Solution {
    public bool MakeEqual(string[] words) {
        int n = words.Length;
        int[] m=new int[26];
        for(int i=0;i<n;i++)
        {
            int s=words[i].Length;
             for(int j=0;j<s;j++)
            {
                m[words[i][j]-'a']++;
            } 
        }
        for (int i = 0; i < 26;i++)
        {
            if(m[i]!=0)
            {
                if (m[i] % n != 0) return false;
            }
        }
        return true;
    }
}