using LinkedLists;
using LinkedLists.Models;
using Xunit;

namespace LinkedListsTests
{
    public class DuplicateRemoverTests
    {
        private readonly DuplicateRemover _duplicateRemover = new DuplicateRemover();
        private readonly Node<int> _linkedList = new Node<int>(0);

        [Fact]
        public void RemoveReturnCorrectType()
        {
            Assert.IsType<Node<int>>(_duplicateRemover.Remove(_linkedList));
        }
    }
}
