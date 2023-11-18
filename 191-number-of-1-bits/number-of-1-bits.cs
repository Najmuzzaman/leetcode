public class Solution {
    public int HammingWeight(uint n) {
        int con=0;
        while(n!=0)
        {
            if(n%2==1) con++;
            n/=2;
        }
        return con;
    }
}