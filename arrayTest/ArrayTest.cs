using array;

namespace arrayTest
{
    public class ArrayTest
    {
        private Array<int> _arr;

        public ArrayTest()
        {
            _arr = new Array<int>();
        }

        [Fact]
        public void AddTest()
        {
            // 3A-> Arrange - Act - Assertion
            _arr.Add(1);
            _arr.Add(2);
            _arr.Add(3);

            Assert.Equal(3, _arr.Count);
            Assert.Equal(4, _arr.Capacity);
        }

        [Fact]
        public void RemoveTest()
        {
            _arr.Add(1);
            _arr.Add(2);
            _arr.Add(3);

            var item = _arr.Remove();
            Assert.Equal(3, item);
            Assert.Equal(2, _arr.Count);
            Assert.Equal(2, _arr.Remove());
            Assert.Equal(1, _arr.Count);
            Assert.Equal(1, _arr.Remove());
            Assert.Equal(0, _arr.Count);
        }

        [Fact]
        public void AddExceptionTest()
        {
            _arr = new array.Array<int>(new int[] { 1, 2, 3, 4 });
            Assert.Throws<Exception>(() => _arr.Add(5));
        }

        [Fact]
        public void RemoveExceptionTest()
        {
            Assert.Throws<Exception>(() => _arr.Remove());
        }

        [Fact]
        public void AddDoubleTest()
        {
            _arr.Add(1);
            _arr.Add(2);
            _arr.Add(3);
            _arr.Add(4);
            Assert.Equal(4, _arr.Count);
            Assert.Equal(4, _arr.Capacity);

            _arr.Add(5);
            Assert.Equal(5, _arr.Count);
            Assert.Equal(8, _arr.Capacity);
            Assert.Equal(1, _arr.FindAt(0));
        }

        [Fact]
        public void FindAtExceptionTest()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _arr.FindAt(0));
        }
    }
}