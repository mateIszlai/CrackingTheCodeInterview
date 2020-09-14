using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class EditIdentifierTests
    {
        private readonly EditIdentifier _editIdentifier = new EditIdentifier();

        [Test]
        public void IsEditedMaxOnceReturnBoolean()
        {
            Assert.That(_editIdentifier.IsEditedMaxOnce("p", "p") == true || _editIdentifier.IsEditedMaxOnce("p", "p") == false);
        }

        [Test]
        public void NoOperationReturnTrue()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("a", "a"));
        }

        [Test]
        public void NoOperationReturnTrue1()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("abcdwfeugregwga", "abcdwfeugregwga"));
        }

        [Test]
        public void InsertReturnTrue()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("a", "ab"));
        }

        [Test]
        public void InsertReturnTrue1()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("avrieubvvba", "avriexubvvba"));
        }

        [Test]
        public void RemoveReturnTrue()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("abcd", "abd"));
        }

        [Test]
        public void RemoveReturnTrue1()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("abegzwcwzvcacd", "abegzwcwzvcac"));
        }

        [Test]
        public void ReplaceOneReturnTrue()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("abc", "adc"));
        }

        [Test]
        public void ReplaceOneReturnTrue1()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("gczuagcutrac", "gczuagcutrax"));
        }

        [Test]
        public void DoubleInsertReturnFalse()
        {
            Assert.IsFalse(_editIdentifier.IsEditedMaxOnce("abcdhriev", "abchdhrjiev"));
        }

        [Test]
        public void DoubleRemoveReturnFalse()
        {
            Assert.IsFalse(_editIdentifier.IsEditedMaxOnce("abcdhriev", "acdhiev"));
        }

        [Test]
        public void DoubleReplaceReturnFalse()
        {
            Assert.IsFalse(_editIdentifier.IsEditedMaxOnce("abcdhriev", "abcvhxiev"));
        }

        [Test]
        public void DoubleMixedReturnFalse()
        {
            //One remove, one insert
            Assert.IsFalse(_editIdentifier.IsEditedMaxOnce("nvurhervgai", "nvrhervgaie"));
        }

        [Test]
        public void DoubleMixedReturnFalse1()
        {
            // One insert, one replace
            Assert.IsFalse(_editIdentifier.IsEditedMaxOnce("mvhcebabvvrz", "mvhcpebabgvrz"));
        }

        [Test]
        public void DoubleMixedReturnFalse2()
        {
            // One replace, one remove
            Assert.IsFalse(_editIdentifier.IsEditedMaxOnce("vnrzavgaea", "vnrxavgea"));
        }
    }
}
