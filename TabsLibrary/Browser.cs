using DataStructures.LinkedList.Doubly;
using System.Collections;

namespace TabsLibrary
{
    public class Browser : IEnumerable
    {
        private DoublyLinkedList<Tab> browserList;

        public Browser()
        {
            browserList = new DoublyLinkedList<Tab>();
        }

        public Browser(IEnumerable items)
        {
            foreach (Tab item in items)
            {
                Add(item);
            }
        }

        public void Add(Tab item)
        {
            browserList.AddLast(item);
        }

        public Tab Remove()
        {
            var removedTab = browserList.RemoveLast();
            return removedTab;
        }

        public Tab GetTabById(int index)
        {
            var temp = browserList.Head;
            while (temp != null)
            {
                if (temp.Value.Id.Equals(index))
                    return temp.Value;
                temp = temp.Next;
            }

            throw new Exception("Searched tab not found!");
        }

        public IEnumerator GetEnumerator()
        {
            return browserList.GetEnumerator();
        }
    }
}
