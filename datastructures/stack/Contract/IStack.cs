namespace DataStructures.Stack.Contract;

public interface IStack<T>
{
    int Count { get; }
    void Push(T item);
    T Pop();
    T Peek();
}
