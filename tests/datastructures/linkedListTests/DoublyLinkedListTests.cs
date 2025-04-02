using DataStructures.LinkedList.Doubly;

namespace linkedListTests
{
    public class DoublyLinkedListTests
    {

        [Fact]
        public void AddFirst_Test()
        {
            var node = new DbNode<char>('z');
            var dbList = new DoublyLinkedList<char>(
                ['a', 'b', 'c']
                );

            if (dbList.Head is not null)
            {
                dbList.Head.Prev = node;
                node.Next = dbList.Head;
            }

            dbList.Head = node;

            Assert.Equal('z', dbList.Head.Value);
            Assert.Equal('a', node.Next?.Value);
        }

        [Fact]
        public void AddLast_Test()
        {
            var node = new DbNode<char>('z');
            var dbList = new DoublyLinkedList<char>(
                ['a', 'b', 'c']
                );
            if (dbList.Tail is not null)
            {
                dbList.Tail.Next = node;
                node.Prev = dbList.Tail;
            }
            dbList.Tail = node;

            Assert.Equal(node, dbList.Tail);
            Assert.Equal('c', dbList.Tail?.Prev?.Value);
        }

        [Fact]
        public void AddAfter_Test()
        {
            var dbList = new DoublyLinkedList<char>(
                ['a', 'b', 'c']
                );

            if (dbList.Head is not null && dbList.Head.Next is not null)
                dbList.AddAfter(dbList.Head.Next, 'z');

            Assert.Equal('z', dbList.Head?.Next?.Next?.Value);
        }

        [Fact]
        public void Constructor_Default_HeadAndTailAreNull()
        {
            var linked = new DoublyLinkedList<string>();

            Assert.Null(linked.Head);
            Assert.Null(linked.Tail);
        }

        [Fact]
        public void Constructor_WithCollection_InitializesListCorrectly()
        {
            var linked = new DoublyLinkedList<char>("hello");

            Assert.Equal('h', linked.Head?.Value);
            Assert.Equal('o', linked.Tail?.Value);
        }

        [Fact]
        public void AddFirst_EmptyList_AddsFirstNode()
        {
            var linked = new DoublyLinkedList<char>();
            linked.AddFirst('a');

            Assert.Equal('a', linked.Head?.Value);
        }

        [Fact]
        public void AddFirst_NotEmptyList_AddsFirstNode()
        {
            var linked = new DoublyLinkedList<char>("hello");
            linked.AddFirst('a');

            Assert.Equal('a', linked.Head?.Value);
        }

        [Fact]
        public void AddLast_EmptyList_AddsLastNode()
        {
            var linked = new DoublyLinkedList<char>();
            linked.AddLast('a');

            Assert.Equal('a', linked.Tail?.Value);
        }

        [Fact]
        public void AddLast_NotEmptyList_AddsLastNode()
        {
            var linked = new DoublyLinkedList<char>("hello");
            linked.AddLast('a');

            Assert.Equal('a', linked.Tail?.Value);
        }

        [Fact]
        public void RemoveFirst_SingleNodeList_RemovesSingleNode()
        {
            var linked = new DoublyLinkedList<char>("h");
            var item = linked.RemoveFirst();

            Assert.True(item.Equals('h'));
        }

        [Fact]
        public void RemoveFirst_MultipleNodesList_RemovesFirstNode()
        {
            var linked = new DoublyLinkedList<char>("hello");
            var item = linked.RemoveFirst();
            var item2 = linked.RemoveFirst();

            Assert.True(item.Equals('h'));
            Assert.True(item2.Equals('e'));
        }

        [Fact]
        public void RemoveLast_SingleNodeList_RemovesSingleNode()
        {
            var linked = new DoublyLinkedList<char>("h");
            var item = linked.RemoveLast();

            Assert.True(item.Equals('h'));
        }

        [Fact]
        public void RemoveLast_MultipleNodesList_RemovesLastNode()
        {
            var linked = new DoublyLinkedList<char>("hello");
            var item = linked.RemoveLast();
            var item2 = linked.RemoveLast();

            Assert.True(item.Equals('o'));
            Assert.True(item2.Equals('l'));
        }
    }
}
