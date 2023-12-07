public class Solution {
    public string LargestOddNumber(string num) {
        int n = num.Length;
        string s="";
        for(int i=n-1;i>=0;i--)
        {
            int a = Convert.ToInt32(num[i].ToString());
            if(a%2==1)
            {
                s = num.Substring(0, i+1);
                break;
            }
        }
        return s;
    }
}