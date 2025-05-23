using DataStructures.Trees.BinaryTree;

namespace treeTests
{
    public class NodeTest
    {
        [Fact]
        public void Node_Create_Test()
        {
            Node<int> node = new Node<int>();
            node.Value = 5;

            Assert.Equal(5, node.Value);
            Assert.Equal(null, node.Left);
            Assert.Equal(null, node.Right);
            Assert.True(node.IsLeaf);
        }

        [Fact]
        public void Node_Insertion_Test()
        {
            Node<int> node = new Node<int> { Value = 5 }; // ROOT
            Node<int> nodeLeft = new Node<int> { Value = 15 }; // Leaf
            Node<int> nodeRight = new Node<int> { Value = 20 }; // Leaf

            node.Left = nodeLeft;
            node.Right = nodeRight;

            Assert.Equal(5, node.Value);
            Assert.Equal(15, node.Left.Value);
            Assert.Equal(20, node.Right.Value);
        }
    }
}
