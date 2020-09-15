using LinkedLists;
using LinkedLists.Models;
using Xunit;

namespace LinkedListsTests
{
    public class DuplicateRemoverTests
    {
        private readonly DuplicateRemover _duplicateRemover = new DuplicateRemover();
        private readonly Node<int> _linkedList = new Node<int>(0);
        private readonly Node<int> _expected = new Node<int>(0);


        public DuplicateRemoverTests()
        {
            SeedData();
        }

        [Fact]
        public void RemoveReturnCorrectType()
        {
            Assert.IsType<Node<int>>(_duplicateRemover.Remove(_linkedList));
        }

        [Fact]
        public void RemoveWorksForOneRemove()
        {
            _linkedList.Append(5);
            Assert.Equal(_expected, _duplicateRemover.Remove(_linkedList));
        }

        [Fact]
        public void RemoveWorksForOneRemoveFromHead()
        {
            _linkedList.Append(0);
            Assert.Equal(_expected, _duplicateRemover.Remove(_linkedList));
        }

        [Fact]
        public void RemoveWorksForOneRemoveFromEnd()
        {
            _linkedList.Append(9);
            Assert.Equal(_expected, _duplicateRemover.Remove(_linkedList));
        }

        private void SeedData()
        {
            for (int i = 1; i < 10; i++)
            {
                _linkedList.Append(i);
                _expected.Append(i);
            }
        }
    }
}
