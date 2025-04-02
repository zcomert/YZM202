using CompanyClassLibrary;
using DataStructures.Array;
using DataStructures.LinkedList.Singly;

var empArray = new Array<Employee>(new List<Employee>()
{
    new Employee(0, "Ali","Veli"),
    new Employee(1, "Mehmet","Sahin"),
    new Employee(2, "Onur","Kamil")
});

Console.WriteLine("Array Employee 3: " + empArray[2].FullName);

var linkedlistEmployee = new SinglyLinkedList<Employee>(new List<Employee>()
{
    new Employee(0, "Ali","Veli"),
    new Employee(1, "Mehmet","Sahin"),
    new Employee(2, "Onur","Kamil")
});

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