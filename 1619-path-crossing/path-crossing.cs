public class Solution {
    public bool IsPathCrossing(string path) {
        List<Tuple<int,int>> point=new List<Tuple<int,int>>();
        int x=0,y=0;
        point.Add(Tuple.Create(x,y));
        foreach(char c in path)
        {
            if(c=='N')
            {
                x+=1;
            }
            else if(c=='E')
            {
                y+=1;
            }
            else if(c=='S')
            {
                x-=1;
            }
            else if(c=='W')
            {
                y -= 1;
            }
            Tuple<int,int> n=new Tuple<int,int>(x,y);
            if(point.Contains(n))
            {
                return true;
            }
            point.Add(n);
        }
        return false;
    }
}