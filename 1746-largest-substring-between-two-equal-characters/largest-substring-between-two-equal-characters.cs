public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int n = s.Length;
        int[] m=new int[27];
        int dis=0;
        bool flag = false;
        for(int i=0;i<n;i++)
        {
            if (m[s[i] - 'a']!=0)
            {
                int a=i-m[s[i] - 'a'];
                if (dis < a)
                    dis = a;
                flag = true;
            }
            else
                m[s[i] - 'a']=i+1;
        }
        return flag?dis:-1;
    }
}