namespace array
{
    public class Array<T>
    {
        private T[] _arr;
        private int _index = 0;

        public int Count { get => _index; }
        public int Capacity { get => _arr.Length; }

        public Array()
        {
            _arr = new T[4];
        }

        public Array(int size)
        {
            _arr = new T[size];
        }

        public Array(ICollection<T> values) : this()
        {
            foreach (T value in values)
                Add(value);
        }

        public void Add(T item)
        {
            if (Count == Capacity)
                // throw new Exception("The array is full!");
                _arr = DoubleArray(_arr);
            _arr[_index] = item;
            _index++;
        }

        public T FindAt(int index)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException("The index out of range!");
            return _arr[index];
        }

        private T[] DoubleArray(T[] arr)
        {
            T[] new_array = new T[arr.Length * 2];
            for (int i = 0; i < Count; i++)
                new_array[i] = arr[i];
            return new_array;
        }

        public T Remove()
        {
            if (Count == 0)
                //throw new Exception("The array is empty");
                _arr = HalfArray(_arr);
            var item = _arr[_index - 1];
            _arr[_index - 1] = default(T);
            _index--;
            return item;
        }

        private T[] HalfArray(T[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
