using LinkedLists;
using LinkedLists.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListsTests
{
    public class DuplicateRemoverTests
    {
        private readonly DuplicateRemover _duplicateRemover = new DuplicateRemover();
        private readonly Node<int> _linkedList = new Node<int>(0);
        private Node<int> _expected = new Node<int>(0);


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
            _expected = _expected.Delete(toAppend);
            _expected.Append(toAppend);
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

        [Theory]
        [MemberData(nameof(TestInputs))]
        public void RemoveWorksWhenMoreToRemove(params int[] toAppend)
        {
            foreach (var number in toAppend)
            {
                _linkedList.Append(number);
                _expected = _expected.Delete(number);
                _expected.Append(number);
            }
            var actual = _duplicateRemover.Remove(_linkedList);
            Assert.Equal(_expected, actual);
        }

        public static IEnumerable<object[]> TestInputs()
        {
            yield return new object[] { new int[] {2, 3}};
            yield return new object[] { new int[] {2, 4, 6}};
            yield return new object[] { new int[] {1, 5, 7, 8}};
            yield return new object[] { new int[] {0, 3}};
            yield return new object[] { new int[] {2, 9}};
            yield return new object[] { new int[] {0, 9}};
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
