namespace leet_code_csharp.stack;

public class MinStack
{
    private readonly Stack<int> _stack;
    private readonly Stack<int> _minStack;

    public MinStack()
    {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
    }

    public void Push( int val )
    {
        _stack.Push( val );

        int min = Math.Min( val, _minStack.Count == 0 ? val : _minStack.Peek() );
        _minStack.Push( min );
    }

    public void Pop()
    {
        _stack.Pop();
        _minStack.Pop();
    }

    public int Top()
    {
        return _stack.Pop();
    }

    public int GetMin()
    {
        return _minStack.Peek();
    }
}
