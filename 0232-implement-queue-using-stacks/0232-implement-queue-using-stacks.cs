public class MyQueue {
    private Stack<int> st1;
    private Stack<int> st2;
    public MyQueue()
    {
        st1 = new Stack<int>();
        st2 = new Stack<int>();
    }

    public void Push(int x)
    {
        while (st1.Count > 0)
        {
            st2.Push(st1.Pop());
        }
        st1.Push(x);
        while (st2.Count > 0)
        {
            st1.Push(st2.Pop());
        }
    }

    public int Pop()
    {
        return st1.Pop();
    }
    public int Peek()
    {
        return st1.Peek();
    }
    public bool Empty()
    {
        return st1.Count==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */