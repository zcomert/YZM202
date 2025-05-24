using System.Collections;
using DataStructures.Array.Contracts;

namespace DataStructures.Array;

public class StaticArray<T> : IArray<T>, IEnumerable<T>
{
    protected T[] _innerArray;

    public StaticArray(int size = 4)
    {
        _innerArray = new T[size];
    }

    public StaticArray(IEnumerable<T> collection)
    {
        _innerArray = new T[collection.Count()];
        int i = 0;
        foreach (var item in collection)
        {
            SetItem(i, item);
            i++;
        }
    }

    public int Length => _innerArray.Length;

    public IEnumerator GetEnumerator()
    {
        return _innerArray.GetEnumerator();
    }

    public T GetItem(int index)
    {
        CheckIndex(index);
        return _innerArray[index];
    }

    public void SetItem(int index, T value)
    {
        CheckIndex(index);
        _innerArray[index] = value;
    }

    protected void CheckIndex(int index)
    {
        if (index < 0 || index >= _innerArray.Length)
            throw new IndexOutOfRangeException();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return new ArrayEnumerator<T>(_innerArray);
    }
}