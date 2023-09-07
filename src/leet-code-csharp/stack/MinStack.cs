/*
 * 155
 * Min Stack
 * 
 * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
 * 
 * Implement the MinStack class:
 *   MinStack() initializes the stack object.
 *   void push(int val) pushes the element val onto the stack.
 *   void pop() removes the element on the top of the stack.
 *   int top() gets the top element of the stack.
 *   int getMin() retrieves the minimum element in the stack.
 *   
 * You must implement a solution with O(1) time complexity for each function.
 * 
 * https://leetcode.com/problems/min-stack/
 */

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
