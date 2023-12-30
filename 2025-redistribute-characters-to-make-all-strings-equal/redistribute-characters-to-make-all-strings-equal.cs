public class Solution {
    public bool MakeEqual(string[] words) {
        int n = words.Length;
        int[] m=new int[30];
        for(int i=0;i<n;i++)
        {
            foreach(char a in words[i])
            {
                m[a - 'a']++;
            }
        }
        for (int i = 0; i < 30;i++)
        {
            if(m[i]!=0)
            {
                if (m[i] % n != 0) return false;
            }
        }
        return true;
    }
}