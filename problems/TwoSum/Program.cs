using DataStructures.Array;

(int, int) TwoSumWithBruteForce(Array<int> array, int target)
{
    for (int i = 0; i < array.Count - 1; i++)
        for (int j = i + 1; j < array.Count; j++)
            if ((array.GetItem(i) + array.GetItem(j)) == target)
                return (i, j);

    return (-1, -1);
}

(int, int) TwoSumWithHashMap(Array<int> array, int target)
{
    Dictionary<int, int> map = [];

    for (int i = 0; i < array.Count; i++)
    {
        var minus = target - array.GetValue(i);
        if (map.TryGetValue(minus, out int value))
            return (value, i);

        if (!map.ContainsKey(array.GetValue(i)))
            map.Add(array.GetValue(i), i);
    }
    return (-1, -1);
}

Array<int> arr = new([2, 3, 4]);
int target = 4;

var result = TwoSumWithBruteForce(arr, target);
var result_2 = TwoSumWithHashMap(arr, target);
Console.WriteLine(result);
Console.WriteLine(result_2);