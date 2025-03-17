// Utku -> Mehmet -> Tirsit -> Fatma -> NULL

// q: SinglyLinkedListNode<String> nasıl oluşturabilirim?

using DataStructures.LinkedList.Singly;

var node1 = new SinglyLinkedListNode<String>("Utku");
var node2 = new SinglyLinkedListNode<String>("Mehmet");
var node3 = new SinglyLinkedListNode<String>("Tirsit");
var node4 = new SinglyLinkedListNode<String>("Fatma");

node1.Next = node2;
node2.Next = node3;
node3.Next = node4;

AddFirst("Ali");
AddFirst("Kardelen");

// q: nodes nasıl dolaşırım?
var current = node1;
while(current is not null)
{
    System.Console.WriteLine(current);
    current = current.Next;
}

void AddFirst(String name)
{
    var newNode = new SinglyLinkedListNode<String>(name);
    newNode.Next = node1;
    node1 = newNode;
}