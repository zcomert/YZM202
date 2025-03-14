using DataStructures.Array;

bool RepeatedItemCheckWithSort(Array<int> arr)
{
    var sortedArray = arr.Sort();
    for (int i = 0; i < arr.Count - 1; i++)
        if (arr.GetItem(i).Equals(arr.GetItem(i + 1))) // _innerArray[i] == _innerArray[i+1]
            return true;
    return false;
}

bool RepeatedItemCheckWithSets(Array<int> arr)
{
    HashSet<int> sets = new HashSet<int>();
    for (int i = 0; i < arr.Count; i++)
    {
        if (sets.Contains(arr.GetItem(i)))
            return true;
        sets.Add(arr.GetItem(i));
    }
    return false;
}

Array<int> array = new Array<int>(new int[] {0, 7, 1, 9, 5, 2, 2});

Console.WriteLine("Output (Using Sort): " + RepeatedItemCheckWithSort(array));
Console.WriteLine("Output (Using Set): " + RepeatedItemCheckWithSets(array));
