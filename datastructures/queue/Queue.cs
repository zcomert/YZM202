using DataStructures.Queue.Contract;

namespace DataStructures.Queue;

public class Queue<T> : IQueue<T>
{
    private IQueue<T> _queue;

    public Queue()
    {
        _queue = new LinkedListQueue<T>();
    }

    public int Count => _queue.Count;

    public T Dequeue()
    {
        return _queue.Dequeue();
    }

    public void Enqueue(T item)
    {
        _queue.Enqueue(item);
    }

    public T Peek()
    {
        return _queue.Peek();
    }
}