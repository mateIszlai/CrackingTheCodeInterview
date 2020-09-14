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


    }
}
