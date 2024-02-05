public class Solution {
    public bool HalvesAreAlike(string s) {
        int n = s.Length;
        int frist = 0, second = 0;
        int firsthalf=n/2;
        for (int i = 0; i < firsthalf; i++)
        {
            if(s[i]=='A' || s[i]=='E' || s[i]=='I' || s[i]=='O' || s[i]=='U' || s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u')
                frist++;
        }
        for (int i = firsthalf; i < n;i++)
        {
            if(s[i]=='A' || s[i]=='E' || s[i]=='I' || s[i]=='O' || s[i]=='U' || s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u')
                second++;
        }
        return (frist == second);
    }
}