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

        [Theory]
        [InlineData(5)]
        [InlineData(0)]
        [InlineData(9)]

        public void RemoveWorksForOneRemove(int toAppend)
        {
            _linkedList.Append(toAppend);
            Assert.Equal(_expected, _duplicateRemover.Remove(_linkedList));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(-2)]
        public void RemoveWorksForNoRemove(int toAppend)
        {
            
            _linkedList.Append(toAppend);
            _expected.Append(toAppend);
            
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
