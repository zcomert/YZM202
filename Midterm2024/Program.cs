using DataStructures.Array;
using DataStructures.LinkedList.Doubly;
using DataStructures.LinkedList.Singly;
using Midterm2024;

int[] arr = new int[] { 0, 0, 1, 2, 3 };

Checker<int> checker = new Checker<int>();
Console.WriteLine(checker.ContainsDuplicate(arr));

SinglyLinkedList<int> intLL = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6 });
var reverseLL = checker.ReverseList(intLL.Head);

foreach (var item in reverseLL)
{
    Console.Write(" - " + item);
}

Console.WriteLine("\n");

DoublyLinkedList<int> reverseEnum = new DoublyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6 });

foreach (var item in reverseEnum)
{
    Console.Write(" - " + item);
}

Console.WriteLine("\n");

Array<int> array = new Array<int>(new int[] { 1, 2, 3, 4, 5, 6 });
SinglyLinkedList<int> newList = checker.ToSinglyLinkedList(array);

foreach (var item in newList)
{
    Console.Write(" - " + item);
}