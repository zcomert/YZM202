using DataStructures.Stack.Contract;

namespace DataStructures.Stack;

public class FixedStack<T> : IStack<T>
{
    private T[] _innerArray;
    private int index = 0;
    public FixedStack(int size=4)
    {
        _innerArray = new T[size];
    }

    public int Count => index;

    public T Peek()
    {
        if (index == 0)
            throw new InvalidOperationException("Stack is empty");
        return _innerArray[index-1];
    }

    public T Pop()
    {
        if (index == 0)
            throw new InvalidOperationException("Stack is empty");

        T temp = _innerArray[index-1];
        index--;
        return temp;
    }

    public void Push(T item)
    {
        if(index >= _innerArray.Length)
            throw new InvalidOperationException("Stack is full");
        _innerArray[index] = item;
        index++;
    }
}