using DataStructures.Array;

var myArray = new Array<int>(5);
myArray.Add(3);
myArray.Add(5);
myArray.Add(8);
myArray.Add(6);
myArray.Add(1);

for (int i = 0; i < myArray.Length; i++)
    Console.WriteLine(myArray[i]);

