using DataStructures.Array;

var numbers = new Array<int>(5);
numbers.Add(19);
numbers.Add(25);
numbers.Add(71);
numbers.Add(77);
numbers.Add(52);
numbers.Add(31);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

System.Console.WriteLine(numbers.Count + "/" + numbers.Capacity);