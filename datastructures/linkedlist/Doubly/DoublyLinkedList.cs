using System.Collections;
using DataStructures.LinkedList.Contracts;
namespace DataStructures.LinkedList.Doubly;

public class DoublyLinkedList<T> : IDoublyLinkedList<T>, IEnumerable<T>
{
    public DbNode<T>? Head { get; set; }
    public DbNode<T>? Tail { get; set; }

    private bool isHeadNull { get; set; }

    public DoublyLinkedList()
    {
        this.isHeadNull = true;
    }

    public DoublyLinkedList(IEnumerable<T> collection) : this()
    {
        foreach (var item in collection)
        {
            AddLast(item);
        }
    }

    public void AddFirst(T item)
    {
        var node = new DbNode<T>(item); // node oluşturuldu
        if (isHeadNull) // Head null ise
        {
            Head = node;
            Tail = node; // Tail = Head;
            isHeadNull = false;
            return; // Added! İşlem yapıldıktan sonra return ile kesilmelidir. 
        }

        Head.Prev = node; // Head'in önceki node'u node olacak
        node.Next = Head; // node'un sonraki node'u Head olacak
        Head = node; // Head node'u node olacak
    }

    public void AddLast(T item)
    {
        var node = new DbNode<T>(item);
        if (isHeadNull)
        {
            Head = node;
            Tail = node; // Tail = Head;
            isHeadNull = false;
            return; // Added! İşlem yapıldıktan sonra return ile kesilmelidir.
        }

        Tail.Next = node;
        node.Prev = Tail;
        Tail = node;
    }

    public void AddAfter(DbNode<T> node, T item)
    {
        var newNode = new DbNode<T>(item);

        if (isHeadNull)
        {
            Head = newNode;
            Tail = newNode;
            isHeadNull = false;
            return;
        }

        if (Tail.Equals(node))
        {
            AddLast(item);
            return;
        }

        var temp = Head;
        while (temp != null)
        {
            if (temp.Equals(node))
            {
                newNode.Next = temp.Next;
                temp.Next.Prev = newNode;
                newNode.Prev = temp;
                temp.Next = newNode;
                return;
            }
            temp = temp.Next;
        }

        throw new Exception("Given node not found!");
    }

    public T RemoveFirst()
    {
        if (isHeadNull)
            throw new Exception("The linked list is empty!");

        T item = default;

        if (Head.Equals(Tail))
        {
            item = Head.Value;
            Head = null;
            Tail = null;
            return item;
        }

        item = Head.Value;
        Head = Head.Next;
        Head.Prev = null;
        return item;
    }

    public T RemoveLast()
    {
        if (isHeadNull)
            throw new Exception("The linked list is empty!");

        if (Head.Equals(Tail))
        {
            T item2 = Head.Value;
            Head = null;
            Tail = null;
            return item2;
        }

        T item = Tail.Value;
        Tail = Tail.Prev;
        Tail.Next = null;
        return item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new DbLinkedListEnumerator<T>(Head, Tail);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
