using System.Collections;
namespace DataStructures.Array;

public class ArrayEnumerator<T> : IEnumerator<T>
{
    private T[] _array;
    private int index;

    public ArrayEnumerator(T[] array)
    {
        _array = array;
        index = -1;
    }
    public T Current => _array[index];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _array = null;
    }

    public bool MoveNext()
    {
        if (index < _array.Length - 1)
        {
            index++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        index = -1;
    }
}
