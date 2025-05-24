using DataStructures.Array;
using DataStructures.LinkedList.Singly;
using SchoolClassLibrary;

var studentArray = new Array<Student>(
[
    new("Ali", "Dag", 0),
    new("Veli", "Akif", 1),
    new("Emir", "Ozkale", 2),
    new("Can", "Kaleli", 2),
]);

Console.WriteLine("Array Student 2: " + studentArray[1].FullName);

var llStudent = new SinglyLinkedList<Student>(
[
    new("Ali", "Dag", 0),
    new("Veli", "Akif", 1),
    new("Emir", "Ozkale", 2)
]);

var temp = llStudent.Head;
var count = 1;
while (temp != null)
{
    if (count == 2)
    {
        break;
    }
    temp = temp.Next;
    count++;
}

Console.WriteLine("Linked List Student 2: " + temp?.Value?.FullName);

var list = studentArray.ToList();
list.ForEach(c => System.Console.WriteLine(c));