using LinkedLists.Models;
using System.Collections.Generic;
using Xunit;

namespace LinkedListsTests
{
    public class LinkedListNodeTests
    {
        private Node<int> _linkedListNode;

        public LinkedListNodeTests()
        {
            _linkedListNode = new Node<int>(0);
        }

        private void FillList(Node<int>head, IEnumerable<int> datas)
        {
            foreach (var data in datas)
            {
               head.Append(data);
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void AppendWork(int data)
        {
            _linkedListNode.Append(data);
            Assert.Equal(data, _linkedListNode.Next.Data);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void AppendWorkForMoreData(int data, int data1, int data2)
        {
            _linkedListNode.Append(data);
            _linkedListNode.Append(data1);
            _linkedListNode.Append(data2);

            Assert.Equal(data, _linkedListNode.Next.Data);
            Assert.Equal(data1, _linkedListNode.Next.Next.Data);
            Assert.Equal(data2, _linkedListNode.Next.Next.Next.Data);
        }

        [Fact]
        public void DeleteWorkForElementInList()
        {
            FillList(_linkedListNode, new int[] { 1, 2, 3, 4, 5 });
            _linkedListNode = _linkedListNode.Delete(3);
            var expected = new Node<int>(0);
            FillList(expected, new int[] { 1, 2, 4, 5 });

            Assert.Equal(expected, _linkedListNode);
        }

        [Fact]
        public void DeleteWorkForDeleteHead()
        {
            FillList(_linkedListNode, new int[] { 1, 2, 3, 4, 5 });
            _linkedListNode = _linkedListNode.Delete(0);
            var expected = new Node<int>(1);
            FillList(expected, new int[] { 2, 3, 4, 5 });

            Assert.Equal(expected, _linkedListNode);
        }

        [Fact]
        public void DeleteWorkForDeleteEnd()
        {
            FillList(_linkedListNode, new int[] { 1, 2, 3, 4, 5 });
            _linkedListNode = _linkedListNode.Delete(5);
            var expected = new Node<int>(0);
            FillList(expected, new int[] { 1, 2, 3, 4});

            Assert.Equal(expected, _linkedListNode);
        }
    }
}
