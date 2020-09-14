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
            Assert.That(_palindromPermutationIdentifier.IsPlaindromePermutation("abc") == true || _palindromPermutationIdentifier.IsPlaindromePermutation("abc") == false);
        }
    }
}
