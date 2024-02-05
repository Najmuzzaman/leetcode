public class Solution {
    public int EvalRPN(string[] tokens)
    {
        int n= tokens.Length;
        Stack<int> st=new Stack<int> ();
        int Ans = 0;
        for(int i=0;i<n;i++)
        {
            if(tokens[i]=="/")
            {
                int first = st.Pop();
                int second= st.Pop();
                int cal= second/first;
                st.Push(cal); 
            }
            else if (tokens[i]=="*")
            {
                int first = st.Pop();
                int second= st.Pop();
                int cal=second * first;
                st.Push(cal);
            }
            else if (tokens[i] == "+")
            {
                int first = st.Pop();
                int second= st.Pop();
                int cal= second + first;
                st.Push(cal);
            }
            else if (tokens[i] == "-")
            {
                int first = st.Pop();
                int second= st.Pop();
                int cal= second-first;
                st.Push(cal);
            }
            else
            {
                st.Push( Convert.ToInt32(tokens[i]) );
            }
        }
        return st.Pop();

    }
}