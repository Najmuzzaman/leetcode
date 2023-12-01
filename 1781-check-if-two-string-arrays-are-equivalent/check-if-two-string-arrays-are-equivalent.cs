public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int k=0, l=0;
        int totalLength = word1.Sum(word => word.Length);
        int totalLength1 = word2.Sum(word => word.Length);
        if (totalLength != totalLength1) return false;
        for(int i=0;i<word1.Length;i++)
        {
            for (int j = 0; j < word1[i].Length;j++)
            {
                
                char a=word1[i][j];
                char b=word2[k][l];
                if (a != b) return false;
                l++;
                if(l==word2[k].Length)
                {
                    k++;
                    l = 0;   
                }            
            }
        }
        return true;
    }
}