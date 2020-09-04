using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class PermutationIdentifierTests
    {
        private readonly PermutationIdentifier _permutationIdentifier = new PermutationIdentifier();

        [Test]
        public void isPermutationReturnsBool()
        {
            var actual = _permutationIdentifier.isPermutation("abcd", "fjei");
            Assert.That(actual == true || actual == false);
        }

        [Test]
        public void isPermutationBasic()
        {
            Assert.IsTrue(_permutationIdentifier.isPermutation("a", "a"));
        }

        [Test]
        public void isPermutationBasic1()
        {
            Assert.IsFalse(_permutationIdentifier.isPermutation("a", "b"));
        }
    }
}
