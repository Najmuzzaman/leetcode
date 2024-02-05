public class Solution {
    public bool IsValid(string s) {
        List<char> Stack = new List<char>();
        foreach (char c in s)
        {
            if(c=='(' || c=='{' || c=='[')
                Stack.Add(c);
            else
            {
                if(Stack.Count != 0)
                {
                    char b = Stack[Stack.Count - 1];
                    if ((b == '(' && c == ')') || (b == '{' && c == '}') || (b == '[' && c == ']'))
                    {
                        Stack.RemoveAt(Stack.Count - 1);
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
        }
        if (Stack.Count != 0) return false;
        return true;
    }
}