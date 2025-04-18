using CompanyClassLibrary;
using DataStructures.Array;
using DataStructures.LinkedList.Singly;

var empArray = new Array<Employee>(
[
    new(0, "Ali","Veli"),
    new(1, "Mehmet","Sahin"),
    new(2, "Onur","Kamil")
]);

Console.WriteLine("Array Employee 3: " + empArray[2].FullName);

var linkedlistEmployee = new SinglyLinkedList<Employee>(
[
    new(0, "Ali","Veli"),
    new(1, "Mehmet","Sahin"),
    new(2, "Onur","Kamil")
]);

var temp = linkedlistEmployee.Head;
var count = 0;

while (temp != null)
{
    if (count == 2)
        break;
    temp = temp.Next;
    count++;
}

Console.WriteLine("Linked List Employee 3: " + temp?.Value?.FullName);