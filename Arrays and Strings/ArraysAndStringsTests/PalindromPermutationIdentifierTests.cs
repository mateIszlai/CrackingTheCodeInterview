using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class PalindromPermutationIdentifierTests
    {
        private readonly PalindromPermutationIdentifier _palindromPermutationIdentifier = new PalindromPermutationIdentifier();

        [Test]
        public void IsPermutationPalindromeReturnBoolean()
        {
            Assert.That(_palindromPermutationIdentifier.IsPalindromePermutation("abc") == true || _palindromPermutationIdentifier.IsPalindromePermutation("abc") == false);
        }

        [Test]
        public void GivenEmptyStringReturnFalse()
        {
            Assert.IsFalse(_palindromPermutationIdentifier.IsPalindromePermutation(string.Empty));
        }

        [Test]
        public void GivenOneCharacterReturnTrue()
        {
            Assert.IsTrue(_palindromPermutationIdentifier.IsPalindromePermutation("a"));
        }

        [Test]
        public void SimpleTrueCase()
        {
            Assert.IsTrue(_palindromPermutationIdentifier.IsPalindromePermutation("abab"));
        }

        [Test]
        public void SimpleTrueCase1()
        {
            Assert.IsTrue(_palindromPermutationIdentifier.IsPalindromePermutation("ababc"));
        }

        [Test]
        public void SimpleFalseCase()
        {
            Assert.IsFalse(_palindromPermutationIdentifier.IsPalindromePermutation("ab"));
        }

        [Test]
        public void SimpleFalseCase1()
        {
            Assert.IsFalse(_palindromPermutationIdentifier.IsPalindromePermutation("abbacd"));
        }
    }
}
